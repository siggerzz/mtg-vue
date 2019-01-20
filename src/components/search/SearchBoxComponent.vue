<template>
<div class="search-box">
    <form @submit.prevent="handleSubmit">
        <input class="search-input" type="text" autocomplete="off" placeholder="Search terms...">
        <input class="search-button" value="SEARCH" type="submit" @click.stop.prevent="submit()">
    </form>
  </div>
</template>

<script>
export default {
    name: 'SearchBoxComponent',
    data(){
      return {
        foobar : null
      }
    },
    methods: {
      submit(){
         //if you want to send any data into server before redirection then you can do it here
        this.$router.push("/search-results");
      }
    }
    
}
</script>

<style lang="scss">
.search-input {
  background-color: #c2c2c2;
  height: 27px;
  font-style: italic;
  font-size: .9em;
  font-weight: bold;
  color: #4c4b4b;
  padding: 0px;
  border: 0px;
  padding-left: 5px;
}

  .search-input {
      width:90%;
  }

  .search-button {
    background: #434343;
    font-weight: bold;
    border: #191919 solid 1px;
    color: white;
    height: 29px;
  }

@media only screen and (min-width: 750px) {
  .search-input {
    display: inline-block;
    width:85%;
  }
  
  .search-button {
    height: 29px;
    font-size: 12pt;
    width: 14%;
    position: relative;
    left: 2px;
  }
}

@media only screen and (max-width: 750px) {

  .search-input {
    display: block;
    margin: 0 auto;
  }
  .search-button {
    font-size: 20pt;
    margin-top:10px;
    height:36px;
    width: 91%;
  }
}
</style>
