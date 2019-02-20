<template>
    <div class="products">
        <b-container>
            <h1 class="mt-4 mb-4">Products</h1>
            <b-row>
                <b-col class="mb-4" sm="6" v-for="product in products" :key="product.id">
                    <b-media class="product">
                        <img slot="aside" :src="product.thumbnail" :alt="product.name" @click="view(product)" />
                        <h2 class="mt-2" @click="view(product)">{{ product.name }}</h2>
                        <p class="mt-4 mb-4">
                            {{ product.shortDescription }}
                        </p>
                        <p class="mt-4 mb-4">{{ product.price }}</p>
                        <b-button variant="primary">Add to cart</b-button>
                    </b-media>
                </b-col>
            </b-row>
        </b-container>
    </div>
</template>

<script>
export default {
    name: "product-list",
    props: {
        products: {
            type: Array,
            required: true
        }
    },
    methods: {
        select(product) {
            this.$router.push(`/products/${product.slug}`);
        }
    }
}
</script>

<style>
    * {
        box-sizing: border-box !important;
    }
    .products {
        padding: 20px;
        max-width: 1200px;
        margin: 0 auto;
    }
    .list .item {
        width: 25%;
        float: left;
        padding: 20px 10px 20px 0;
    }
    .list img,
    .list h3,
    .list p {
        cursor: pointer;
    }
    .list img {

    width: 100px;
    }
</style>