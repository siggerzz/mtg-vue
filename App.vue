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

.checkbox-container {
  display: inline-block;
  position: relative;
  padding-left: 35px;
  padding-right:10px;
  margin-bottom: 15px;
  cursor: pointer;
  font-size: 16px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
}

.checkbox-container input {
  position: absolute;
  opacity: 0;
  cursor: pointer;
  height: 0;
  width: 0;
}

.checkbox-container:hover input ~ .checkmark {
  background-color: #ccc;
}

.checkbox-container input:checked ~ .checkmark {
  background-color: #d4341a;
}

.checkmark {
  position: absolute;
  top: 0;
  left: 0;
  height: 25px;
  width: 25px;
  background-color: #232323;
}

@media only screen and (max-width: 750px) {
}
</style>
