import Vue from 'vue'
import VueRouter from 'vue-router';
import App from '../App.vue';
import HomePage from './views/Home.vue';
import SearchResultsPage from './views/SearchResults.vue';
import CardDetailsPage from './views/CardDetails.vue';
import store from '../src/store/store';

Vue.use(VueRouter);


const routes = [
  { path: '/', component: HomePage },
  { path: '/search-results', component: SearchResultsPage},
  { path: '/cardDetails', component: CardDetailsPage}
]

const router = new VueRouter({
  routes,
  mode: 'history'
})

new Vue({
  el: '#app',
  router,
  store,
  components: { App },
  render: h => h(App)
}).$mount('#app')
