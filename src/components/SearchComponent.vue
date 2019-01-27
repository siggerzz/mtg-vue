<template>
<div>
  <SearchBoxComponent/>
  <div class="search-by-container">
      <SearchCardComponent class="search-card-component"/>
      <SearchColourComponent class="search-colour-component"/>
  </div>
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
            <option value="test" v-for="(set, index) in setsResponse.sets" :key=index>{{set.name}}</option>
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
</div>
</template>

<script>
import { RepositoryFactory } from '../api/repositories/RepositoryFactory';
import SearchBoxComponent from './search/SearchBoxComponent.vue';
import SearchCardComponent from './search/SearchCardComponent.vue';
import SearchColourComponent from './search/SearchColourComponent.vue';

const SetsRepository = RepositoryFactory.get('sets');

export default {
  name: 'SearchComponent',
  components: {
    SearchBoxComponent,
    SearchCardComponent,
    SearchColourComponent
  },
  data() {
    return {
      setsResponse: {}
  }},
  methods: {
      async fetchSets() {
      await SetsRepository.getSets().then(response => {
      this.setsResponse = (response.data);
  })}},
  created() {
    this.fetchSets();
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>





//Filter By Component
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

@media screen and (max-width: 750px) {
    .search-by-container {
    width: 90%;
    margin: 0 auto;
    display: block;
    text-align: center;
  }

  .filter-by-container {
    width:90%;
    margin:0 auto;
  }

  .filter-by-container h3, p {
    text-align: center;
  }
}

@media only screen and (min-width: 750px) {
  .search-by-container {
    text-align:left;
    width:60%;
    display:inline-grid;
  }
  .search-by-container {
    text-align:left;
    width:60%;
    display:inline-grid;
}

  .filter-by-container {
    display:inline-grid;
    width:40%;
  }
}

</style>
