<template>
<div class="search-box">
    <form @submit.prevent="handleSubmit">
        <input class="search-input" type="text" autocomplete="off" placeholder="Search terms...">
        <input class="search-button" type="submit" @click.stop.prevent="submit()">
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
  color:black;
  height: 30px;
  font-size: 20px;
  font-style: italic;
}

  .search-input {
      width:90%;
  }

@media only screen and (min-width: 750px) {
  .search-button {
    height: 36px;
  }
}

@media only screen and (max-width: 750px) {

  .search-input {
    display: block;
    margin: 0 auto;
  }
  .search-button {
    height:36px;
    width: 90%;
  }
}
</style>
