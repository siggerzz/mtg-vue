<template>
    <div class="cardDetailsContainer">
        <div class="titleContainer">
            <h2>{{this.$store.state.search.card.name}}</h2>
        </div>
        <div class="cardContent">
            <div class="leftColumn">
                <div class="cardImageContainer">
                    <img id="cardCircle" src="../../assets/card/cardCircles.png"/>
                    <img id="cardImage" v-bind:src="`${this.$store.state.search.card.imageUrl}`"/>
                </div>
            </div>
            <div class="rightColumn">
                <div class="columnHeader">
                    <div class="headerName">Oracle</div>
                    <div class="headerName">Printed</div>
                </div>
                <div class="nameRow row">
                    <div class="label">Name</div>
                    <div class="value">{{this.$store.state.search.card.name}}</div>
                </div>
                <div class="manaCostRow row">
                    <div class="label">Mana Cost</div>
                    <div class="value">
                    <img v-for="(mana, index) in this.$store.state.search.card.manaCost" :key=index v-bind:src="`http://gatherer.wizards.com/Handlers/Image.ashx?size=medium&name=${mana}&type=symbol`">
                    </div>
                </div>
                <div class="cmcRow row">
                    <div class="label">Converted Mana Cost</div>
                    <div class="value">{{this.$store.state.search.card.cmc}}</div>
                </div>
                <div class="typesRow row">
                    <div class="label">Types</div>
                    <div class="value">{{this.$store.state.search.card.types}}</div>
                </div>
                <div class="cardTextRow row">
                    <div class="label">Card Text</div>
                    <div class="value">{{this.$store.state.search.card.text}}</div>
                </div>
                <div class="flavourTextRow row">
                    <div class="label">Flavour Text</div>
                    <div class="value">{{this.$store.state.search.card.flavor}}</div>
                </div>
                <div class="expansionRow row">
                    <div class="label">Expansion</div>
                    <div class="value">Commander 2018</div>
                </div>
                <div class="rarityRow row">
                    <div class="label">Rarity</div>
                    <div class="value">{{this.$store.state.search.card.rarity}}</div>
                </div>
                <div class="allSetsRow row">
                    <div class="label">Sets</div>
                    <div class="value">set 1, set 2</div>
                </div>
                <div class="cardNumberRow row">
                    <div class="label">Card Number</div>
                    <div class="value">{{this.$store.state.search.card.number}}</div>
                </div>
                <div class="artistRow row">
                    <div class="label">Artist</div>
                    <div class="value">{{this.$store.state.search.card.artist}}</div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex';
import { RepositoryFactory } from '../../api/repositories/RepositoryFactory';
const CardsRepository = RepositoryFactory.get('cards');
export default {
    name:'CardDetails',
    methods: {
    async fetchCard() {
    await CardsRepository.getCard(this.$route.query.multiverseId).then(response => {
    this.$store.dispatch('setCardResponse', response.data);
    })
    }
},
  ...mapActions( {
    setCardResponse: 'setCardResponse'
  }),
    created() {
    this.fetchCard();
  }
}
</script>

<style lang="scss">

#cardCircle {
    z-index:-99;
}

@media only screen and (min-width: 750px) {

    .header {
        margin-bottom:21px;
    }

    .cardDetailsContainer {
        width:700px;
    }
    .cardDetailsContainer {
        .titleContainer {
            height:102px;

            h2 {
                font-family: "beleren bold";
                font-size: 24pt;
            }
        }
    }
    .leftColumn {
        display: inline-block;
        vertical-align: top;
        width:340px;

        .cardImageContainer {
            position:relative;
        }

        #cardCircle {
            position: absolute;
            left: -14px;
        }

        #cardImage {
            position: relative;
            left: 8px;
            top: 40px;
        }
    }

    .rightColumn {
        display: inline-block;
        width: 337px;
        height:500px;
        padding: 0px;
        background-color: #1f1e1e;
        
        .columnHeader {
            height:32px;
            display: block;

            .headerName {
                display: inline-block;
                width:168.5px;
                height:35px;
                padding-top:5px;
            }
        }

        .row {
            padding-top: 2px;
            padding-bottom: 2px;
            padding-left: 10px;

            .label {
                display: inline-block;
                width:130px;
                font-family: 'Open Sans', sans-serif;
                font-weight: 700;
                font-style: normal;
                text-align: left;
                font-size: .7em;
                vertical-align: top;
            }

            .value {
                display: inline-block;
                width: 190px;
                text-align: left;
                font-family: 'Open Sans', sans-serif;
                font-size: .85em;
            }
        }
    }
}
</style>
