import Vue from 'vue'
import VueRouter from 'vue-router';
import App from '../App.vue';
import HomePage from './pages/Home';
import SearchResultsPage from './pages/SearchResults';

Vue.use(VueRouter);

const routes = [
  { path: '/', component: HomePage },
  { path: '/search-results', component: SearchResultsPage }
]

const router = new VueRouter({
  routes
})

const app = new Vue({
  el: '#app',
  router,
  components: { App },
  render: h => h(App),
}).$mount('#app')
