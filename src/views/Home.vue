<template>
<div class="search-container container">
    <SearchComponent/>
</div>
</template>

<script>
import SearchComponent from '../components/SearchComponent.vue';

export default {
  name: 'HomePage',
  components: {
    SearchComponent
  }
}
</script>
