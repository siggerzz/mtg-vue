<template>
<div class="search-box">
    <form>
        <input class="search-input" type="text" autocomplete="off" placeholder="Search term">
        <input class="search-button" type="submit">
        </form>
    </div>
</template>

<script>
export default {
    name: 'SearchBoxComponent'
    
}
</script>

<style>
.search-input {
  width:100%;
  background-color: #c2c2c2;
  color:black;
}
</style>
