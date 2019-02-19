<template>
    <div>
        <product-list />
    </div>
</template>

<script>
import ProductList from "./products/List.vue"
export default {
    name: 'app',
    components: {
        ProductList
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
    .list, .details {
        width: 50%;
        float: left;
    }
    .list .item {
        width: 50%;
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
