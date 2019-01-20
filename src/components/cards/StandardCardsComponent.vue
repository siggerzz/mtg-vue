<template>
<table>
    <tbody>
        <tr class="standard-card-item">
            <td class="leftCol">
                <a href="/card">
                    <img class="cardImage" src="../../assets/search-results/card/Card.jpg"/>
                    </a>
            </td>
            <td class="middleCol">
                <div class="cardInfo">
                    <span class="cardTitle"><a href="/card">Test</a></span>
                    <span class="manaCost">
                        <img src="../../assets/search-results/card/mana-cost/3-small.jpg">
                        <img src="../../assets/card-colours/white.png">
                        <img src="../../assets/card-colours/white.png">
                        <img src="../../assets/card-colours/white.png">
                    </span>
                        <span class="convertedManaCost">(6)</span>
                        <span class="cardType">Creature - Angel (6/6)</span>
                        <div class="rulesText">
                            <p>Flying</p>
                            <p>Landfall — Whenever a land enters the battlefield under your control, you may exile target nonland permanent other than Admonition Angel.</p>
                            <p>When Admonition Angel leaves the battlefield, return all cards exiled with it to the battlefield under their owners' control.</p>
                            </div>
                </div>

            </td>
            <td class="rightCol">
                <p>Right Col</p>
            </td>
        </tr>
    </tbody>
</table>
</template>

<script>
</script>

<style lang="scss">
.standard-card-item td {
    border-style:solid;
    border-width: 1px;
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
    max-width: 150px;
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