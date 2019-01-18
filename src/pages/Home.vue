<template>
  <div id="app">
    <SearchComponent class="search-container"/>
    <Layout/>
  </div>
</template>

<script>
import SearchComponent from '../components/SearchComponent';

export default {
  name: 'home',
  components: {
    SearchComponent
  }
}
</script>

<style>
.search-container {
  width:50%;
  margin: 0 auto;
}
</style>
