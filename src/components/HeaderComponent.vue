<template>
  <div id="header">
    <img class="logo" alt="MTG Logo" src="../assets/mtg-logo.png">
    <h1>Welcome to the MTG Card Search Vue app!</h1>
  </div>
</template>

<script>

export default {
  name: 'header',
  components: {
  }
}
</script>

<style>

body {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  background-image: url('../assets/background.jpg');
  text-align: center;
  color: #ffffff;
}

.logo {
  height:100px;
}
#header {
  margin-top: 20px;
}
</style>
