<template>
  <div id="app">
  <HeaderComponent/>
  <router-view></router-view>
  </div>
</template>

<script>

import HeaderComponent from './src/components/HeaderComponent';

export default {
  name:'app',
  components: {
    HeaderComponent
  } 
}
</script>
