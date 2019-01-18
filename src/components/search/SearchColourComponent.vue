<template>
<div class="search-colour">
    <h3>Search by Colour:</h3>
    <p class="colour-type first"><input name="white" type="checkbox"><img src="../../assets/card-colours/white.png"></p>
    <p class="colour-type"><input name="blue" type="checkbox"><img src="../../assets/card-colours/blue.png"></p>
    <p class="colour-type"><input name="black" type="checkbox"><img src="../../assets/card-colours/black.png"></p>
    <p class="colour-type"><input name="red" type="checkbox"><img src="../../assets/card-colours/red.png"></p>
    <p class="colour-type"><input name="green" type="checkbox"><img src="../../assets/card-colours/green.png"></p>
    <p><input name="match-colours" type="checkbox"> Match Colors Exactly (use 'and' instead of 'or')</p>
    <p><input name="exclude-colours" type="checkbox">Exclude Unselected Colors (limit by selection)</p>
    <p><input name="match-multicoloured" type="checkbox">Exclude Unselected Colors (limit by selection)</p>
</div>
</template>

<script>
export default {
    name: 'SearchColourComponent'
}
</script>

<style>

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
</style>
