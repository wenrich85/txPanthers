<template>
  <div>
    <div v-if="loading">
      <p> Loading... </p>
    </div>
    
    <div v-else v-for="user in users" :key=user.id> 
      <h1> {{user.firstName}} {{user.lastName}} </h1>
      <h2> {{ user.phone }} - {{ user.email}}</h2>
    </div>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
      <div class="container">
        <router-link to="/" class="navbar-brand">Texas Panthers</router-link>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav ml-auto">
            <li class="nav-item">
              <router-link to="/" class="nav-link">Home</router-link>
            </li>
            <li class="nav-item">
              <router-link to="/schedule" class="nav-link">Schedule</router-link>
            </li>
            <li class="nav-item">
              <router-link to="/players" class="nav-link">Players</router-link>
            </li>
            <!-- Add more navigation items as needed -->
          </ul>
        </div>
      </div>
    </nav>

  </div>
</template>

<script>
export default {
  name: 'IndexPage',


data() {
    return {
      users: [],
      loading: false
    };
  },
  watch: {
    
  },
  async created () {
      const headers = { "Content-Type": "application/json" };
      this.loading = true

       await fetch(' http://localhost:5175/api/Members',{
        headers,
        method: "GET",
      })
        .then((response) => {
          response.json().then((data) => {
            console.log(data)
            this.users = data;
          });
        })
        .catch((err) => {
          console.error(err);
        })
        .finally(() => (this.loading = false));
    
  },
  methods: {
    fetchData() {
      const headers = { "Content-Type": "application/json" };
      this.loading = true

      fetch(' http://localhost:5175/api/all',{
        headers,
        method: "GET",
      })
        .then((response) => {
          response.json().then((data) => {
            console.log(data)
            this.users = data;
          });
        })
        .catch((err) => {
          console.error(err);
        })
        .finally(() => (this.loading = false));
    },

    formatPhone (phone) {
      return 
    } 
  }
}

</script>
