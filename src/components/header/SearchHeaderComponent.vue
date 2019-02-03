<template>
    <div class="bannerBackground">
        <div class="bannerContainer">
          <div class="headerSearch">
            <div class="logoContainer">
            <a href="/">
              <img src="../../assets/mtg-logo.png">
            </a>
              </div>
            <div class="searchRight">
              <div class="titleContainer">
                <a href="/"><h1>GATHERER</h1></a>
              </div>
            <SearchBoxComponent/>
            </div>
            </div>
          </div>
        </div>
</template>

<script>
import SearchBoxComponent from '../search/SearchBoxComponent.vue';

export default {
  name: 'SearchHeaderComponent',
  components: {
    SearchBoxComponent
  }
}
</script>

<style lang="scss">

body {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  background-image: url('../../assets/background.jpg');
  text-align: center;
  color: #ffffff;
}

.titleContainer h1 {
  font-family: 'beleren bold';
}

.titleContainer a, a:visited {
  text-decoration: none;
}



@media only screen and (max-width: 750px) {

  .bannerBackground a img {
    width:300px;
  }
}
@media screen and (min-width: 750px){
  .bannerBackground {
    background-color: #191919;
  }
.bannerContainer {
    width: 870px;
    margin: 0 auto;
}
.logoContainer {
    width: 275px;
    height: auto;
    display: inline-block;
}

.logoContainer img {
  width:100%;
  height: auto;
}

.searchRight {
    width: 480px;
    display: inline-block;
    vertical-align: top;
}

.searchRight .search-input {
  width:380px;
  display: inline-block;
}
.searchRight .search-button {
  width:88px;
  display: inline-block;
}

.titleContainer {
  display: block;
  text-align: left;
}

.titleContainer h1 {
  font-size: 20pt;
  margin-top: 0px;
  margin-bottom: 0px;
  color:white;
}

.searchBox {
    float: left;
    width: 470px;
  }
}

.searchLinks {
  width: 480px;
}
.searchLinks div {
  float:left;
}
</style>
