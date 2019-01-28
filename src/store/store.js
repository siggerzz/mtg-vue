import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

const state = {
  search: {
  cards: {},
  selectedColours: []
  }
}

const mutations = {
  setSelectedColours(state, selectedColours)
  {
    state.search.selectedColours = selectedColours;
  },
  setCards(state, cardsResponse)
  {
    state.search.cards = cardsResponse;
  }
}

const actions = {
  setSelectedColours(context, selectedColours) {
    context.commit('setSelectedColours', selectedColours);
  },
  setCardsResponse(context, cardsResponse) {
    context.commit('setCards', cardsResponse);
  }
}

const getters = {
  getSelectedColours: state => {
    return state.search.selectedColours;
  },
  getCardsResponse: state => {
    return state.search.cards;
  }
}

export default new Vuex.Store({
  state,
  actions,
  mutations,
  getters
})