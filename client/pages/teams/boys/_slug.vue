<template>
    <div>
    <h1> Team: {{ slug }} </h1>
    <players />
    </div>
</template>
<script>
import Players from '../../../components/player/Players.vue';

export default ({
    async asyncData({params}) {
        const slug = params.slug
        return { slug, params }
    },

    components: {
        Players
    }
})
</script>
