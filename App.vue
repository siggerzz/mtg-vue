<template>
  <div id="app">
  <HeaderComponent/>
  <router-view></router-view>
  </div>
</template>

<script>

import HeaderComponent from './src/components/HeaderComponent.vue';

export default {
  name:'app',
  components: {
    HeaderComponent
  } 
}
</script>

<style lang="scss">
.container {
  margin: 0 auto;

  @media only screen and (min-width: 750px) {
    width:650px;
  }
}
</style>
