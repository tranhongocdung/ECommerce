<template>
    <div class="products">
        <h1>Products</h1>
        <div class="list">
            <div class="item" v-for="product in products" :key="product.slug">
                <h3 @click="select(product)">{{ product.name }}</h3>
                <img :src="product.thumbnail" :alt="product.name" @click="select(product)" />
                <p @click="select(product)">{{ product.shortDescription }}</p>
                <p @click="select(product)">{{ product.price }}</p>
                <hr />
            </div>
        </div>
        <product-details class="details" v-if="selectedProduct" :product="selectedProduct" />


    </div>
</template>

<script>
import ProductDetails from "./Details.vue"

export default {
    name: "product-list",
    components: {
        ProductDetails
    },
    data() {
            return {
            products: [
                {
                    name: "Sony Xperia Z5",
                    slug: "sony-xperia-z5",
                    thumbnail: "http://placehold.it/200x300",
                    shortDescription:
                    "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                    price: 499.99,
                    description:
                    "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam perspiciatis explicabo maiores fuga provident aobcaecati tenetur nostrum, quidem quod dignissimos, voluptatem quasi? Nisiquaerat, fugit voluptas ducimus facilis impedit quod dicta, laborum sint"
                },
                {
                    name: "Samsung Galaxy S8",
                    slug: "samsung-galaxy-s8",
                    thumbnail: "http://placehold.it/200x300",
                    shortDescription:
                    "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                    price: 499.99,
                    description:
                    "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam perspiciatis explicabo maiores fuga provident aobcaecati tenetur nostrum, quidem quod dignissimos, voluptatem quasi? Nisiquaerat, fugit voluptas ducimus facilis impedit quod dicta, laborum sint"
                },
                {
                    name: "Samsung Galaxy A7",
                    slug: "samsung-galaxy-a7",
                    thumbnail: "http://placehold.it/200x300",
                    shortDescription:
                    "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                    price: 499.99,
                    description:
                    "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam perspiciatis explicabo maiores fuga provident aobcaecati tenetur nostrum, quidem quod dignissimos, voluptatem quasi? Nisiquaerat, fugit voluptas ducimus facilis impedit quod dicta, laborum sint"
                },
                {
                    name: "HTC One Plus",
                    slug: "htc-one-plus",
                    thumbnail: "http://placehold.it/200x300",
                    shortDescription:
                    "Samsung Galaxy S8 Android smartphone with true edge to edge display",
                    price: 499.99,
                    description:
                    "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis tempora ad cum laudantium, omnis fugit amet iure animi corporis labore repellat magnam perspiciatis explicabo maiores fuga provident aobcaecati tenetur nostrum, quidem quod dignissimos, voluptatem quasi? Nisiquaerat, fugit voluptas ducimus facilis impedit quod dicta, laborum sint"
                }
            ],
            selectedProduct : null
        }
    },
    methods: {
        select(product) {
            this.selectedProduct = product
        }
    }
}
</script>