<template>
<div class="search-box">
    <form @submit.prevent="handleSubmit">
        <input class="search-input" type="text" autocomplete="off" placeholder="Search term">
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

<style>
.search-input {
  width:100%;
  background-color: #c2c2c2;
  color:black;
}
</style>
