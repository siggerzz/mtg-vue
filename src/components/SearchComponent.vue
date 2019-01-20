<template>
<div>
  <SearchBoxComponent/>
  <div class="search-by-container">
      <SearchCardComponent class="search-card-component"/>
      <SearchColourComponent class="search-colour-component"/>
  </div>
    <FilterByComponent class="filter-by-component"/>
</div>
</template>

<script>
import SearchBoxComponent from './search/SearchBoxComponent.vue';
import SearchCardComponent from './search/SearchCardComponent.vue';
import SearchColourComponent from './search/SearchColourComponent.vue';
import FilterByComponent from './search/FilterByComponent.vue';

export default {
  name: 'SearchComponent',
  components: {
    SearchBoxComponent,
    SearchCardComponent,
    SearchColourComponent,
    FilterByComponent
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>

@media screen and (max-width: 750px) {
    .search-by-container {
    width: 90%;
    margin: 0 auto;
    display: block;
    text-align: center;
  }
}

@media only screen and (min-width: 750px) {
  .search-by-container {
    text-align:left;
    width:60%;
    display:inline-grid;
  }
  .search-by-container {
    text-align:left;
    width:60%;
    display:inline-grid;
}

  .filter-by-container {
    display:inline-grid;
    width:40%;
  }
}

</style>
