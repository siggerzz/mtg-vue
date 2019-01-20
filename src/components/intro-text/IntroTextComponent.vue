<template>
<div class="intoTextContainer">
        <span class="introHeader">GATHERER</span>
    <p class="introText">Gatherer is the Magic Card Database. Search for the perfect addition to your deck. Browse through 
        cards from Magic's entire history. See cards from the most recent sets and discover what players 
        just like you are saying about them.
    </p>
</div>
</template>

<script>
export default {
    name:'IntroTextComponent'
}
</script>

<style lang="scss">

.introHeader {
    font-size: 36pt;
    color: #ffffff;
    padding-top: 35px;
    top: 20px;
    position: relative;
    font-family: 'beleren bold';
}

.introText {
    padding-top:30px;
    font-family: 'Open Sans';
    font-size: 12.5pt;
}

@media only screen and (max-width: 750px) {
    .introTextContainer {
        text-align: center;
    }

    .introText {
        font-size: 10pt;
    }

    .introText {
        padding-top: 0px;
    }
}

@media only screen and (min-width: 750px) {
    .intoTextContainer {
    text-align: left;
}
}

</style>
