<template>
<table>
    <tbody>
        <tr class="standard-card-item" v-for="(card, index) in cards" :key=index>
            <td class="leftCol">
                <a v-bind:href="`/CardDetails?multiverseId=${card.multiverseId}`">
                    <img class="cardImage" :srcset="card.imageUrl"/>
                    </a>
            </td>
            <td class="middleCol">
                <div class="cardInfo">
                    <span class="cardTitle" ><a v-bind:href="`/CardDetails?multiverseId=${card.multiverseId}`">{{card.name}}</a></span>
                    <span class="manaCost">
                        <img src="../../assets/search-results/card/mana-cost/3-small.jpg">
                        <img src="../../assets/card-colours/white.png">
                        <img src="../../assets/card-colours/white.png">
                        <img src="../../assets/card-colours/white.png">
                    </span>
                        <span class="convertedManaCost">({{card.cmc}})</span>
                        <span class="cardType">{{card.type}}(6/6)</span>
                        <div class="rulesText">
                            <p>{{card.originalText}}</p>
                        </div>
                </div>

            </td>
            <td class="rightCol">
                <img class="setImage" v-bind:src="`http://gatherer.wizards.com/Handlers/Image.ashx?type=symbol&set=${card.sets[0]}&size=small&rarity=${card.rarity.charAt(0)}`"/>
            </td>
        </tr>
    </tbody>
</table>
</template>

<script>
import { mapGetters } from "vuex";

export default {
    computed: {
    // mix the getters into computed with object spread operator
    ...mapGetters({
      cards: 'getCardsResponse',
      // ...
    })
  }
}
</script>

<style lang="scss">

tr:nth-child(odd) {
    background-color: #3a3939;
}

tr:nth-child(even) {
    background-color: #3d3d3d;
}

.standard-card-item td {
    border-style:none;
}

.middleCol {
    position: relative;
    width:60%;
    text-align: left;
}

.cardTitle, .manaCost {
    display: inline-block;
}

.cardInfo {
    height: 100%;
    padding: 10px;
    position: relative;
}

.cardTitle, .cardType {
    font-weight: bold;
}

.cardType {
    display: block;
}

.rulesText p {
    margin:0px;
}

.cardImage {
    max-width: 95px;
    height: auto;
}

.cardTitle a:link, a:visited{
    text-decoration: none;
    color:#c5c5c5;
}

.manaCost img {
    height: 15px;
    width:15px;
}

.rightCol {
    width:15%;
}

</style>