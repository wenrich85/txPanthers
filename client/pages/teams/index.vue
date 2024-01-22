<template>
    <div>
        <BasketballSVG :year="2024" />

    </div>    
</template>
<script>
import Players from '../../components/player/Players.vue';
import BasketballSVG from '../../components/team/BasketballSVG.vue';

export default ({
    
    components: {
        Players,
        BasketballSVG
    },
    setup() {
        
    },
})
</script>
