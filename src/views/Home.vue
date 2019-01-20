<template>
<div class="search-container container">
  <IntroTextComponent/>
    <SearchComponent/>
</div>
</template>

<script>
import SearchComponent from '../components/SearchComponent.vue';
import IntroTextComponent from '../components/intro-text/IntroTextComponent.vue';

export default {
  name: 'HomePage',
  components: {
    SearchComponent,
    IntroTextComponent
  }
}
</script>
