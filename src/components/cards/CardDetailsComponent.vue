<template>
    <div class="cardDetailsContainer">
        <div class="titleContainer">
            <h2>Adarkar Valkyrie</h2>
        </div>
        <div class="cardContent">
            <div class="leftColumn">
                <div class="cardImageContainer">
                    <img id="cardCircle" src="../../assets/card/cardCircles.png"/>
                    <img id="cardImage" src="../../assets/card/Image.jpg"/>
                </div>
            </div>
            <div class="rightColumn">
                <div class="columnHeader">
                    <div class="headerName">Oracle</div>
                    <div class="headerName">Printed</div>
                </div>
                <div class="nameRow row">
                    <div class="label">Name</div>
                    <div class="value">Adarkar Valkyrie</div>
                </div>
                <div class="manaCostRow row">
                    <div class="label">Mana Cost</div>
                    <div class="value">{R}{R}{W} 3</div>
                </div>
                <div class="cmcRow row">
                    <div class="label">Converted Mana Cost</div>
                    <div class="value">6</div>
                </div>
                <div class="typesRow row">
                    <div class="label">Types</div>
                    <div class="value">Flying, vigilance</div>
                </div>
                <div class="cardTextRow row">
                    <div class="label">Card Text</div>
                    <div class="value">
                        Flying, vigilance When target creature other than Adarkar Valkyrie dies this turn, return that card to the battlefield under your control.
                    </div>
                </div>
                <div class="flavourTextRow row">
                    <div class="label">Flavour Text</div>
                    <div class="value">
                        She doesn't escort the dead to the afterlife, but instead raises them to fight and die again.
                    </div>
                </div>
                <div class="powertoughnessRow row">
                    <div class="label">P/T</div>
                    <div class="value">4/6</div>
                </div>
                <div class="expansionRow row">
                    <div class="label">Expansion</div>
                    <div class="value">Commander 2018</div>
                </div>
                <div class="rarityRow row">
                    <div class="label">Rarity</div>
                    <div class="value">Rare</div>
                </div>
                <div class="allSetsRow row">
                    <div class="label">Sets</div>
                    <div class="value">set 1, set 2</div>
                </div>
                <div class="cardNumberRow row">
                    <div class="label">Card Number</div>
                    <div class="value">60</div>
                </div>
                <div class="artistRow row">
                    <div class="label">Name</div>
                    <div class="value">John Smith</div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name:'CardDetails'
}
</script>

<style lang="scss">

#cardCircle {
    z-index:-99;
}

@media only screen and (min-width: 750px) {
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
        height:523px;
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
                font-family: 'open_sansbold';
                font-weight: bold;
                text-align: left;
                font-size: .7em;
                vertical-align: top;
            }

            .value {
                display: inline-block;
                width: 190px;
                text-align: left;
                font-family: 'open_sansregular';
                font-size: .85em;
            }
        }
    }
}
</style>
