using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Features.Products
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly EcommerceContext _db;
        public ProductsController(EcommerceContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Find(string brands, int? minPrice, int?
                maxPrice, int? minScreen, int? maxScreen, string capacity, string colours,
            string os, string features)
        {
            var Brands = string.IsNullOrEmpty(brands) ? new List<string>() :
                brands.Split('|').ToList();
            var Capacity = string.IsNullOrEmpty(capacity) ? new List<string>() :
                capacity.Split('|').ToList();
            var Colours = string.IsNullOrEmpty(colours) ? new List<string>() :
                colours.Split('|').ToList();
            var OS = string.IsNullOrEmpty(os) ? new List<string>() :
                os.Split('|').ToList();
            var Features = string.IsNullOrEmpty(features) ? new List<string>() :
                features.Split('|').ToList();
            var products = await _db.Products
                .Where(x => Brands.Any() == false || Brands.Contains(x.Brand.Name))
                .Where(x => minPrice.HasValue == false || x.ProductVariants.Any(v =>
                                v.Price >= minPrice.Value))
                .Where(x => maxPrice.HasValue == false || x.ProductVariants.Any(v =>
                                v.Price <= maxPrice.Value))
                .Where(x => minScreen.HasValue == false || x.ScreenSize >=
                            Convert.ToDecimal(minScreen.Value))
                .Where(x => maxScreen.HasValue == false || x.ScreenSize <=
                            Convert.ToDecimal(maxScreen.Value))
                .Where(x => Capacity.Any() == false || x.ProductVariants.Any(v =>
                                Capacity.Contains(v.Storage.Capacity)))
                .Where(x => Colours.Any() == false || x.ProductVariants.Any(v =>
                                Colours.Contains(v.Colour.Name)))
                .Where(x => OS.Any() == false || OS.Contains(x.OS.Name))
                .Where(x => Features.Any() == false || Features.All(f =>
                                x.ProductFeatures.Any(pf => pf.Feature.Name == f)))
                .Select(x => new ProductListViewModel
                {
                    Id = x.Id,
                    Slug = x.Slug,
                    Name = x.Name,
                    ShortDescription = x.ShortDescription,
                    Thumbnail = x.Thumbnail,
                    Price = x.ProductVariants.OrderBy(v => v.Price).First().Price
                })
                .ToListAsync();
            return Ok(products);
        }
        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var product = await _db.Products.SingleOrDefaultAsync(x => x.Slug == slug);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}