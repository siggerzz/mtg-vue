import Vue from 'vue'
import Vuex from 'vuex'
Vue.use(Vuex)

const state = {
  search: {
  cards: {},
  card: {},
  selectedColours: [],
  cardNameSelected : false,
  cardTypesSelected: false,
  cardTextSelected: false,
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
  setCardNameSelected(state, cardNameSelectedValue)
  {
    state.search.cardNameSelected = cardNameSelectedValue;
  },
  setCardTypesSelected(state, cardTypesSelectedValue)
  {
    state.search.cardTypesSelected = cardTypesSelectedValue;
  },
  setCardTextSelected(state, cardTextSelectedValue)
  {
    state.search.cardTextSelected = cardTextSelectedValue;
  },
  setCard(state, cardResponse)
  {
    state.search.card = cardResponse;
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
  setCardNameSelectedValue(context, cardNameSelectedValue) {
    context.commit('setCardNameSelected', cardNameSelectedValue);
  },
  setCardTypesSelectedValue(context, cardTypesSelectedValue) {
    context.commit('setCardTypesSelected', cardTypesSelectedValue);
  },
  setCardTextSelectedValue(context, cardTextSelectedValue) {
    context.commit('setCardTextSelected', cardTextSelectedValue);
  },
  setCardsResponse(context, cardsResponse) {
    context.commit('setCards', cardsResponse);
  },
  setCardResponse(context, cardResponse) {
    context.commit('setCard', cardResponse);
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
  getCardResponse: state => {
    return state.search.card;
  },
  getSelectedSet: state => {
    return state.search.selectedSet;
  },
  getSelectedFormat: state => {
    return state.search.selectedFormat;
  },
  getSelectedType: state => {
    return state.search.selectedType;
  },
  getSelectedNameValue: state => {
    return state.search.cardNameSelected;
  },
  getSelectedTypesValue: state => {
    return state.search.cardTypesSelected;
  },
  getSelectedText: state => {
    return state.search.cardTextSelected;
  }
}

export default new Vuex.Store({
  state,
  actions,
  mutations,
  getters
})