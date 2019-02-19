<template>
    <product-details :product="product" />
</template>

<script>
import ProductDetails from "../components/product/Details.vue";
export default {
    name: "product",
    components: {
        ProductDetails
    },
    data() {
        return {
            product: {
                name: "Sony Xperia Z5",
                    slug: "sony-xperia-z5",
                    thumbnail: "http://placehold.it/200x300",
                    shortDescription:
                    "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                    price: 499.99,
                    description:
                    "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam perspiciatis explicabo maiores fuga provident aobcaecati tenetur nostrum, quidem quod dignissimos, voluptatem quasi? Nisiquaerat, fugit voluptas ducimus facilis impedit quod dicta, laborum sint"
            }
        }
    }
}
</script>
