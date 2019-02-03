<template>
<div>
  <div class="header">
        <SearchHeaderComponent/>
  </div>
    <div class="container">
        <CardDetailsComponent/>
    </div>
</div>
</template>

<script>
import SearchHeaderComponent from '../components/header/SearchHeaderComponent.vue';
import CardDetailsComponent from '../components/cards/CardDetailsComponent.vue';
export default {
    name:'CardDetailsPage',
    components: {
        SearchHeaderComponent,
        CardDetailsComponent
    }
}
</script>

<style lang="sass">

</style>
