import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

const state = {
  search: {
  cards: {},
  selectedColours: [],
  selectedSet: '',
  selectedFormat: '',
  selectedType:''
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
  },
  setSet(state, set)
  {
    state.search.selectedSet = set;
  },
  setFormat(state, format)
  {
    state.search.selectedFormat = format;
  },
  setType(state, type)
  {
    state.search.selectedType = type;
  }
}

const actions = {
  setSelectedColours(context, selectedColours) {
    context.commit('setSelectedColours', selectedColours);
  },
  setCardsResponse(context, cardsResponse) {
    context.commit('setCards', cardsResponse);
  },
  setSelectedSet(context, selectedSet) {
    context.commit('setSet', selectedSet);
  },
  setSelectedFormat(context, selectedFormat) {
    context.commit('setFormat', selectedFormat);
  },
  setSelectedType(context, selectedType) {
    context.commit('setType', selectedType);
  }
}

const getters = {
  getSelectedColours: state => {
    return state.search.selectedColours;
  },
  getCardsResponse: state => {
    return state.search.cards;
  },
  getSelectedSet: state => {
    return state.search.selectedSet;
  },
  getSelectedFormat: state => {
    return state.search.selectedFormat;
  },
  getSelectedType: state => {
    return state.search.selectedType;
  }
}

export default new Vuex.Store({
  state,
  actions,
  mutations,
  getters
})