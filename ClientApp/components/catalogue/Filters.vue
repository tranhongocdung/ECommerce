<template>
    <div class="filters mb-4">
        <h5 class="mt-4">Filters</h5>
        <b-btn variant="outline-secondary" @click.prevent="reset">
            <font-awesome-icon icon="sync" /> Reset
        </b-btn>
        <b-list-group class="mt-4">
            <filter-accordion>
                <span slot="header">Brand</span>
                <b-row slot="body">
                    <b-col cols="6">
                        <div :class="{ 'filter-item': true, 'active': brands.length === 0 }" @click="clearBrands">All</div>
                    </b-col>
                    <b-col cols="6" v-for="item in filters.brands" :key="item">
                        <div :class="{ 'filter-item': true, 'active': brands.indexOf(item) > -1 }" @click="filterBrand(item)">
                            {{ item }}
                        </div>
                    </b-col>
                </b-row>
            </filter-accordion>
            <filter-accordion>
                <span slot="header">Price</span>
                <div class="slider" slot="body">
                    <vue-slider :value="price" formatter="£{value}" :min=0 :max=1000 
                        :interval=50 :lazy=true width="90%" @callback="filterPrice">
                    </vue-slider>
                </div>
            </filter-accordion>
        </b-list-group>
    </div>
</template>

<script>
import FilterAccordion from "./FilterAccordion.vue";
import vueSlider from "vue-slider-component";
export default {
    name: "filters",
    props: {
        filters: {
            type: Object,
            required: true
        }
    },
    components: {
        FilterAccordion,
        vueSlider
    },
    computed: {
        brands() {
            return this.$route.query.brands || "";
        },
        price() {
            return [
                this.$route.query.minPrice || 0,
                this.$route.query.maxPrice || 1000
            ];
        }
    },
    methods: {
        reset() {
            this.$router.push({ query: {} });
        },
        clearBrands() {
            if (this.brands.length) {
                let query = Object.assign({}, this.$route.query);
                delete query.brands;
                this.$router.push({ query: query });
            }
        },
        filterBrand(brand) {
            let query = Object.assign({}, this.$route.query);
            let split = query.brands ? query.brands.split("|") : [];
            if (split.indexOf(brand) > -1) {
                let index = split.indexOf(brand);
                split.splice(index, 1);
            } else {
             split.push(brand);
            }
            if (split.length) {
                let joined = split.join("|");
                query.brands = joined;
            } else {
                delete query.brands;
            }
            this.$router.push({ query: query });
        },
        filterPrice(prices) {
            let query = Object.assign({}, this.$route.query);
            query.minPrice = prices[0];
            query.maxPrice = prices[1];
            this.$router.push({ query: query });
        }
    }
}
</script>

<style lang="scss" scoped>
.filter-item {
    margin: 10px 0;
    border: 1px solid #ccc;
    border-radius: 5px;
    padding: 10px;
    text-align: center;
    cursor: pointer;
    &.active {
        font-weight: bold;
        color: #17a2b8;
        border-color: #17a2b8;
    }
}
.slider {
    padding: 35px 0 10px 10px;
}
</style>
