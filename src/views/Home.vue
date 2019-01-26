<template>
<div>
  <div id="header">
    <HomeHeaderComponent/>
  </div>
  <div class="search-container container">
  <IntroTextComponent/>
    <SearchComponent/>
</div>
</div>
</template>

<script>
import HomeHeaderComponent from '../components/header/HomeHeaderComponent.vue';
import SearchComponent from '../components/SearchComponent.vue';
import IntroTextComponent from '../components/intro-text/IntroTextComponent.vue';

export default {
  name: 'HomePage',
  components: {
    HomeHeaderComponent,
    SearchComponent,
    IntroTextComponent
  }
}
</script>
