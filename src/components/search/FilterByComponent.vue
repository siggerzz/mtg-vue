<template>
    <div>
    <h3>Filter by:</h3>
    <div class="filter-select">
        <p>Card Format:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select">
        <p>Card Set:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select">
        <p>Card Type:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select">
        <p>Select Sort Order:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select">
        <p>Select Output Format:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
    </div>
</template>

<script>
export default {
    name:"FilterByComponent"
}
</script>

<style lang="scss" scoped>

h3 {
    text-align: left;
}
.filter-select {
    text-align: left;
}
.filter-select select {
    width:100%;

}
</style>


