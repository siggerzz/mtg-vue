<template>
<div>
  <div class="header">
        <SearchHeaderComponent/>
  </div>
  <div class="container">
    <StandardCardsComponent :cardsResponse=this.cardsResponse></StandardCardsComponent>
  </div>
</div>
</template>

<script>

import SearchHeaderComponent from '../components/header/SearchHeaderComponent.vue';
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
    StandardCardsComponent,
    SearchHeaderComponent
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

<style lang="scss" scoped>

.container {
  margin-top:200px;
}
</style>
