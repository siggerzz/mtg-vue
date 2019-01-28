<template>
<div>
  <div class="header">
        <SearchHeaderComponent/>
  </div>
  <div class="container">
    <StandardCardsComponent></StandardCardsComponent>
  </div>
</div>
</template>

<script>

import SearchHeaderComponent from '../components/header/SearchHeaderComponent.vue';
import StandardCardsComponent from '../components/cards/StandardCardsComponent.vue';
import { RepositoryFactory } from '../api/repositories/RepositoryFactory';
const CardsRepository = RepositoryFactory.get('cards');
import { mapActions } from 'vuex'

export default {
  name: 'SearchResultsPage',
  components: {
    StandardCardsComponent,
    SearchHeaderComponent
  },
  methods: {
    async fetchCards() {
    await CardsRepository.getCards(this.$route.query.searchTerm, this.$store.state.search.selectedColours.toString()).then(response => {
    this.$store.dispatch('setCardsResponse', response.data);
    })
  },
  ...mapActions( {
    setCardsResponse: 'setCardsResponse'
  })},
  created() {
    this.fetchCards();
  }
}
</script>

<style lang="scss" scoped>

.container {
  margin-top:200px;
}
</style>
