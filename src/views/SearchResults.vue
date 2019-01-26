<template>
  <div class="container">
    <h1>Search Results</h1>
    <StandardCardsComponent :cardsResponse=this.cardsResponse></StandardCardsComponent>
  </div>
</template>

<script>

import StandardCardsComponent from '../components/cards/StandardCardsComponent.vue';
import { RepositoryFactory } from '../api/repositories/RepositoryFactory';
const CardsRepository = RepositoryFactory.get('cards');

export default {
  name: 'SearchResultsPage',
  data() {
    return {
      cardsResponse: {}
    }
  },
  components: {
    StandardCardsComponent
  },
  methods: {
    async fetchCards() {
    await CardsRepository.getCards(this.$route.query.searchTerm).then(response => {
    this.cardsResponse = (response.data);
    })
  }
  },
  created() {
    this.fetchCards();
  }
}
</script>

<style>
</style>
