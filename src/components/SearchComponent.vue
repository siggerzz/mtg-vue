<template>
<div>
  <SearchBoxComponent/>
  <div class="search-by-container">
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
      <div class="search-colour">
   <div class="search-colour-header">
      <h3>Search by Colour:</h3>
   </div>
   <label class="checkbox-container">
        <img src="../assets/card-colours/white.png">
        <input v-model="selectedColours" name="color" value="W" type="checkbox">
        <span class="checkmark"></span>
   </label>
        <label class="checkbox-container">
        <img src="../assets/card-colours/blue.png">
        <input v-model="selectedColours" name="color" value="U" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../assets/card-colours/black.png">
        <input v-model="selectedColours" name="color" value="B" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../assets/card-colours/red.png">
        <input v-model="selectedColours" name="color" value="R" type="checkbox">
        <span class="checkmark"></span>
   </label>
   <label class="checkbox-container">
        <img src="../assets/card-colours/green.png">
        <input v-model="selectedColours" name="color" value="G" type="checkbox">
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
  </div>
    <div class="filter-by-container">
    <h3>Filter by:</h3>
    <div class="filter-select select-style">
        <p>Card Format:</p>
        <select v-model="selectedFormat">
            <option value=""></option>
            <option v-bind:value="format" v-for="(format, index) in filtersResponse.formats" :key=index>{{format}}</option>
        </select>
    </div>
        <div class="filter-select select-style">
        <p>Card Set:</p>
        <select v-model="selectedSet">
            <option value=""></option>
            <option v-bind:value="set.code" v-for="(set, index) in filtersResponse.sets" :key=index>{{set.name}}</option>
        </select>
    </div>
        <div class="filter-select select-style">
        <p>Card Type:</p>
        <select v-model="selectedType">
            <option value=""></option>
            <option v-bind:value="type" v-for="(type, index) in filtersResponse.types" :key=index>{{type}}</option>
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
import {mapGetters} from 'vuex';

const SearchFiltersRepository = RepositoryFactory.get('searchFilters');

export default {
  name: 'SearchComponent',
  components: {
    SearchBoxComponent
  },
  data() {
    return {
      filtersResponse: {}
  }},
  methods: {
      async fetchFilters() {
      await SearchFiltersRepository.getFilters().then(response => {
      this.filtersResponse = (response.data);
  })}},
  created() {
    this.fetchFilters();
  },
  computed : {
    selectedColours: {
    get () {
        return this.$store.getters.getSelectedColours;
    },
    set (value) {
        this.$store.dispatch('setSelectedColours', value)
    }
},
    selectedSet: {
    get () {
        return this.$store.getters.getSelectedSet;
    },
    set (value) {
        this.$store.dispatch('setSelectedSet', value)
    }
},
    selectedFormat: {
    get () {
        return this.$store.getters.getSelectedFormat;
    },
    set (value) {
        this.$store.dispatch('setSelectedFormat', value)
    }
},
    selectedType: {
    get () {
        return this.$store.getters.getSelectedType;
    },
    set (value) {
        this.$store.dispatch('setSelectedType', value)
    }
},
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style lang="scss" scoped>



//Search By Colour Component
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

  .search-colour-header h3 {
    margin-bottom: 0px;
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
