<template>
<div class>
  <SearchBoxComponent/>
  <div class="search-by-container">
      <SearchCardComponent class="search-card-component"/>
      <SearchColourComponent class="search-colour-component"/>
  </div>
  <div class="filter-by-container">
        <FilterByComponent class="filter-by-component"/>
  </div>
</div>
</template>

<script>
import SearchBoxComponent from './search/SearchBoxComponent';
import SearchCardComponent from './search/SearchCardComponent';
import SearchColourComponent from './search/SearchColourComponent';
import FilterByComponent from './search/FilterByComponent';

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
<style scoped>

.search-by-container {
  text-align:left;
  width:60%;
  display:inline-grid;
}

.filter-by-container {
  display:inline-grid;
  width:40%;
}
</style>
