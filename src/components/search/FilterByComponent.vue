<template>
    <div class="filter-by-container">
    <h3>Filter by:</h3>
    <div class="filter-select select-style">
        <p>Card Format:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select select-style">
        <p>Card Set:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select select-style">
        <p>Card Type:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select select-style">
        <p>Select Sort Order:</p>
        <select>
            <option value=""></option>
            <option value="test">Test</option>
        </select>
    </div>
        <div class="filter-select select-style">
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


.select-style {
    border-radius: 3px;
    overflow: hidden;
}

.select-style select {
    width:100%;
    height: 31px;
    border: none;
    box-shadow: none;
    color: #ffffff;
    background-color: #232323;
    -webkit-appearance: none;
}

.select-style select:focus {
    outline: none;
}

@media screen and (min-width: 750px) {
    .filter-by-container {
        width:100%;
    }

    .filter-by-container {
        width:90%;
    }
}

@media screen and (max-width: 750px) {
    .filter-by-container {
        width:90%;
        margin:0 auto;
    }

    .filter-by-container h3, p {
        text-align: center;
    }
}
</style>


