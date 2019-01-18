import Vue from 'vue'
import Header from '../src/components/HeaderComponent.vue'
import Home from '../src/pages/Home.vue'

Vue.config.productionTip = false

new Vue({
  render: h => h(Home),
}).$mount('#app')

new Vue({
  render: h => h(Header),
}).$mount('#header')

