import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

const store = new Vuex.Store({
  state: {
    cards: []
  },
  mutations: {
    setCards(state, cards)
    {
      state.cards = cards;
    }
  }
})
export default new Vuex.Store({
  store
})