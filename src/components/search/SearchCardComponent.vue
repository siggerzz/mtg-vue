<template>
<div class="search-card">
    <h3>Search Card:</h3>
    <p class="card-type first"><input name="name" type="checkbox">Name</p>
    <p class="card-type"><input name="types" type="checkbox">Types</p>
    <p class="card-type"><input name="text" type="checkbox">Text</p>
</div>
</template>

<script>
export default {
    name: 'SearchCardComponent'
}
</script>

<style scoped>

.card-type{
    display:inline-block;
    padding-left:20px;
}

.search-card .first {
    padding-left:0px;
}
</style>
