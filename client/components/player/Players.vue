<template>
  <div class="players">
    <h2>Players</h2>
    <div class="card-deck">
      <PlayerCard v-for="player in players" :key="player.id" :player="player" />
    </div>
  </div>
</template>

<script>
import PlayerCard from "./PlayerCard.vue";

export default {
  components: {
    PlayerCard,
  },
  data() {
    return {
      players: this.genRandomPlayers(),
    };
  },
  methods: {
    genRandomPlayers() {
      let playerList = [];
      let numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21, 23];
      numbers.forEach((number) => playerList.push(this.createPlayer(number)));
      return playerList;
    },
    createPlayer(number) {
      return {
        id: number,
        name: "Player 1",
        age: 15,
        position: "Guard",
        gender: 'f'
      };
    },
  },
};
</script>
<style scoped>

.players {
    padding: 10px;
    max-width: 95vw;
    margin: 0 auto;
}
.card-deck {
  display: grid;
  grid-template-columns: repeat(5, 1fr);
}
</style>
