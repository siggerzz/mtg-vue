<template>
<div class="search-container">
    <SearchComponent/>
</div>
</template>

<script>
import SearchComponent from '../components/SearchComponent';

export default {
  name: 'HomePage',
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
