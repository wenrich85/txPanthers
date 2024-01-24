<template>
  <div class="card">
    <img v-if="player.image" :src="player.image" class="card-img-top" alt="Player Image">
    <img v-else :src="defaultImage" class="card-img-top" alt="Default Player Image">

    <div class="card-body">
      <h5 class="card-title">{{ player.name }}</h5>
      <p class="card-text">Age: {{ player.age }}</p>
      <p class="card-text">Position: {{ player.position }}</p>
    </div>
  </div>
</template>

<script>
export default {
  routeRules: {
    '/': {prerender: true},
  },
  props: {
    player: {
      type: Object,
      required: true,
    },
  },
  data () {
    return {
      // defaultImage: this.getDefaultImage
    }
  },
  computed: {
    
    defaultImage: function () {
        return  this.player.gender === "f" ? "/_nuxt/assets/default-girl-player-image.svg" : "/_nuxt/assets/default-player-image.svg"
      }
    
  },
  methods: {
  }
};
</script>

<style scoped>
.card {
  width: 18rem;
  margin-bottom: 20px;
}
</style>
