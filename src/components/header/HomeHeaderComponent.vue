<template>
    <div class="bannerBackground">
        <div class="bannerContainer">
          <img class="bannerImage" alt="MTG Logo" src="../../assets/header/topbanner.png">
        </div>
        <a href="/">
            <img src="../../assets/mtg-logo.png">
        </a>
    </div>
</template>

<script>

export default {
  name: 'HeaderComponent'
}
</script>

<style lang="scss" scoped>

body {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  background-image: url('../../assets/background.jpg');
  text-align: center;
  color: #ffffff;
}

.bannerBackground a {
    position: absolute;
    top: 0;
    left: 20px;
    right: 475px;
    margin-left: auto;
    margin-right: auto;
    width: 275px;
}



@media only screen and (max-width: 750px) {
  .bannerImage {
    display: none;
  }

  .bannerBackground {
    height: 100px;
  }
}

@media screen and (min-width: 750px){
  .bannerBackground {
    background-color: #191919;
  }
  .bannerBackground a img {
    width: 100%;
}
.bannerBackground a {
    position: absolute;
    top: 0;
    left: 20px;
    right: 475px;
    margin-left: auto;
    margin-right: auto;
    width: 275px;
}

}
</style>
