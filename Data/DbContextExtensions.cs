using System.Collections.Generic;
using System.Linq;
using ECommerce.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Data
{
    public static class DbContextExtensions
    {
        public static UserManager<AppUser> UserManager { get; set; }
        public static void EnsureSeeded(this EcommerceContext context)
        {
            if (UserManager.FindByEmailAsync("stu@ratcliffe.io").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "Stu",
                    LastName = "Ratcliffe",
                    UserName = "stu@ratcliffe.io",
                    Email = "stu@ratcliffe.io",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };
                UserManager.CreateAsync(user, "Password1*").GetAwaiter().GetResult();
            }
            AddColoursFeaturesAndStorage(context);
            AddOperatingSystemsAndBrands(context);
            AddProducts(context);
        }

        public static void AddProducts(EcommerceContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product
                    {
                        Name = "Samsung Galaxy S8",
                        Slug = "samsung-galaxy-s8",
                        Thumbnail = "http://placehold.it/200x300",
                        ShortDescription = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Price = 499.99M,
                        ScreenSize = 5M,
                        TalkTime = 8M,
                        StandbyTime = 36M,
                        Brand = context.Brands.Single(b => b.Name == "Samsung"),
                        OS = context.OSs.Single(os => os.Name == "Android"),
                        Images = new List<Image>
                        {
                            new Image { Url = "/assets/images/gallery1.jpeg" },
                            new Image { Url = "/assets/images/gallery2.jpeg" },
                            new Image { Url = "/assets/images/gallery3.jpeg" },
                            new Image { Url = "/assets/images/gallery4.jpeg" },
                            new Image { Url = "/assets/images/gallery5.jpeg" },
                            new Image { Url = "/assets/images/gallery6.jpeg" }
                        },
                        ProductFeatures = new List<ProductFeature>
                        {
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "3G")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "Bluetooth")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "WiFi")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "GPS")
                            }
                        },
                        ProductVariants = new List<ProductVariant>
                        {
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 299M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 349M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 319M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 369M
                            }
                        }
                    },
                    new Product
                    {
                        Name = "Sony Xperia Z5",
                        Slug = "sony-xperia-z5",
                        Thumbnail = "http://placehold.it/200x300",
                        ShortDescription = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Price = 499.99M,
                        ScreenSize = 5M,
                        TalkTime = 8M,
                        StandbyTime = 36M,
                        Brand = context.Brands.Single(b => b.Name == "Sony"),
                        OS = context.OSs.Single(os => os.Name == "Android"),
                        Images = new List<Image>
                        {
                            new Image { Url = "/assets/images/gallery1.jpeg" },
                            new Image { Url = "/assets/images/gallery2.jpeg" },
                            new Image { Url = "/assets/images/gallery3.jpeg" },
                            new Image { Url = "/assets/images/gallery4.jpeg" },
                            new Image { Url = "/assets/images/gallery5.jpeg" },
                            new Image { Url = "/assets/images/gallery6.jpeg" }
                        },
                        ProductFeatures = new List<ProductFeature>
                        {
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "3G")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "Bluetooth")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "WiFi")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "GPS")
                            }
                        },
                        ProductVariants = new List<ProductVariant>
                        {
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 299M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 349M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 319M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 369M
                            }
                        }
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy A7",
                        Slug = "samsung-galaxy-a7",
                        Thumbnail = "http://placehold.it/200x300",
                        ShortDescription = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Price = 499.99M,
                        ScreenSize = 5M,
                        TalkTime = 8M,
                        StandbyTime = 36M,
                        Brand = context.Brands.Single(b => b.Name == "Samsung"),
                        OS = context.OSs.Single(os => os.Name == "Android"),
                        Images = new List<Image>
                        {
                            new Image { Url = "/assets/images/gallery1.jpeg" },
                            new Image { Url = "/assets/images/gallery2.jpeg" },
                            new Image { Url = "/assets/images/gallery3.jpeg" },
                            new Image { Url = "/assets/images/gallery4.jpeg" },
                            new Image { Url = "/assets/images/gallery5.jpeg" },
                            new Image { Url = "/assets/images/gallery6.jpeg" }
                        },
                        ProductFeatures = new List<ProductFeature>
                        {
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "3G")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "Bluetooth")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "WiFi")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "GPS")
                            }
                        },
                        ProductVariants = new List<ProductVariant>
                        {
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 299M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 349M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 319M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 369M
                            }
                        }
                    },
                    new Product
                    {
                        Name = "HTC One Plus",
                        Slug = "htc-one-plus",
                        Thumbnail = "http://placehold.it/200x300",
                        ShortDescription = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Price = 499.99M,
                        ScreenSize = 5M,
                        TalkTime = 8M,
                        StandbyTime = 36M,
                        Brand = context.Brands.Single(b => b.Name == "HTC"),
                        OS = context.OSs.Single(os => os.Name == "Android"),
                        Images = new List<Image>
                        {
                            new Image { Url = "/assets/images/gallery1.jpeg" },
                            new Image { Url = "/assets/images/gallery2.jpeg" },
                            new Image { Url = "/assets/images/gallery3.jpeg" },
                            new Image { Url = "/assets/images/gallery4.jpeg" },
                            new Image { Url = "/assets/images/gallery5.jpeg" },
                            new Image { Url = "/assets/images/gallery6.jpeg" }
                        },
                        ProductFeatures = new List<ProductFeature>
                        {
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "3G")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "Bluetooth")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "WiFi")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "GPS")
                            }
                        },
                        ProductVariants = new List<ProductVariant>
                        {
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 299M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 349M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 319M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 369M
                            }
                        }
                    },
                    new Product
                    {
                        Name = "Xiaomi Mix 2S",
                        Slug = "xiaomi-mix-2s",
                        Thumbnail = "http://placehold.it/200x300",
                        ShortDescription = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description = "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Price = 499.99M,
                        ScreenSize = 5M,
                        TalkTime = 8M,
                        StandbyTime = 36M,
                        Brand = context.Brands.Single(b => b.Name == "Xiaomi"),
                        OS = context.OSs.Single(os => os.Name == "Android"),
                        Images = new List<Image>
                        {
                            new Image { Url = "/assets/images/gallery1.jpeg" },
                            new Image { Url = "/assets/images/gallery2.jpeg" },
                            new Image { Url = "/assets/images/gallery3.jpeg" },
                            new Image { Url = "/assets/images/gallery4.jpeg" },
                            new Image { Url = "/assets/images/gallery5.jpeg" },
                            new Image { Url = "/assets/images/gallery6.jpeg" }
                        },
                        ProductFeatures = new List<ProductFeature>
                        {
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "3G")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "Bluetooth")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "WiFi")
                            },
                            new ProductFeature
                            {
                                Feature = context.Features.Single(f => f.Name == "GPS")
                            }
                        },
                        ProductVariants = new List<ProductVariant>
                        {
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 299M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Black"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 349M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "32GB"),
                                Price = 319M
                            },
                            new ProductVariant
                            {
                                Colour = context.Colours.Single(c => c.Name == "Gold"),
                                Storage = context.Storages.Single(s => s.Capacity == "64GB"),
                                Price = 369M
                            }
                        }
                    }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
        public static void AddColoursFeaturesAndStorage(EcommerceContext context)
        {
            if (context.Colours.Any() == false)
            {
                var colours = new List<string>() { "Black", "White", "Gold", "Silver", "Grey", "Spacegrey", "Red", "Pink" };
                colours.ForEach(c => context.Colours.Add(new Colour
                {
                    Name = c
                }));
                context.SaveChanges();
            }
            if (context.Storages.Any() == false)
            {
                var storages = new List<string> { "32GB", "64GB" };
                storages.ForEach(c => context.Storages.Add(new Storage
                {
                    Capacity = c
                }));
                context.SaveChanges();
            }
            if (context.Features.Any() == false)
            {
                var feautures = new List<string>() { "3G", "Bluetooth", "WiFi", "GPS" };
                feautures.ForEach(o => context.Features.Add(new Feature
                {
                    Name = o
                }));
                context.SaveChanges();
            }
        }
        public static void AddOperatingSystemsAndBrands(EcommerceContext context)
        {
            if (context.OSs.Any() == false)
            {
                var os = new List<string>() { "Android", "iOS", "Windows" };
                os.ForEach(o => context.OSs.Add(new OS
                {
                    Name = o
                }));
                context.SaveChanges();
            }
            if (context.Brands.Any() == false)
            {
                var brands = new List<string> { "Samsung", "Sony", "Xiaomi", "HTC" };
                brands.ForEach(o => context.Brands.Add(new Brand
                {
                    Name = o
                }));
                context.SaveChanges();
            }
        }
    }
}