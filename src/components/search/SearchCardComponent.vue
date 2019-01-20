<template>
<div class="search-card">
    <h3>Search Card:</h3>
    <div>
        <label class="checkbox-container">Name
            <input name="name" type="checkbox">
            <span class="checkmark"></span>
        </label>
        <label class="checkbox-container">Types
            <input name="types" type="checkbox">
            <span class="checkmark"></span>
        </label>
        <label class="checkbox-container">Text
            <input name="text" type="checkbox">
            <span class="checkmark"></span>
        </label>
    </div>
</div>
</template>

<script>
export default {
    name: 'SearchCardComponent'
}
</script>

<style lang="scss" scoped>


</style>
