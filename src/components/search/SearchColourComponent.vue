<template>
<div class="search-colour">
   <div class="search-colour-header">
      <h3>Search by Colour:</h3>
   </div>
   <label class="checkbox-container">
        <img src="../../assets/card-colours/white.png">
        <input v-model="checkedColors" name="color" value="white" type="checkbox">
        <span class="checkmark"></span>
   </label>
        <label class="checkbox-container">
        <img src="../../assets/card-colours/blue.png">
        <input v-model="checkedColors" name="color" value="blue" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../../assets/card-colours/black.png">
        <input v-model="checkedColors" name="color" value="black" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../../assets/card-colours/red.png">
        <input v-model="checkedColors" name="color" value="red" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../../assets/card-colours/green.png">
        <input v-model="checkedColors" name="color" value="green" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">Match Colors Exactly (use 'and' instead of 'or')
        <input name="text" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">Exclude Unselected Colors (limit by selection)
        <input name="text" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">Exclude Unselected Colors (limit by selection)
        <input name="text" type="checkbox">
        <span class="checkmark"></span>
   </label>
</div>
</template>

<script>
export default {
    name: 'SearchColourComponent',
    data() {
        return {
            checkedColors: []
        }
    }
}
</script>

<style lang="scss">

.colour-type h3 {
    display:block;
}

.colour-type {
    display:inline-block;
    padding-left:20px;
}

.colour-type input {
    padding:12px;
}

.search-colour .first {
    padding-left:0px;
}

@media screen and (max-width: 750px) {
    .search-colour-header h3 {
    margin-bottom: 0px;
    }
    
}
</style>
