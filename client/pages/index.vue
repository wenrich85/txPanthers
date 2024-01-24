<template>
  <div id="app">
    <!-- Navbar -->
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
              <router-link to="/teams" class="nav-link">Teams</router-link>
            </li>
            <li class="nav-item">
              <router-link to="/announcements" class="nav-link">Announcements</router-link>
            </li>
            <!-- Add more navigation items as needed -->
          </ul>
        </div>
      </div>
    </nav>

    <!-- Main Content -->
    <div class="container mt-4">
      <!-- Image Slider Section -->
      <div class="mb-4">
        <h2>Image Slider</h2>
        <!-- Add your image slider component here -->
      </div>

      <!-- Teams Section -->
      <div class="mb-4">
        <h2>Teams</h2>
        <!-- Add your teams component here -->
      </div>

      <!-- Announcements Section -->
      <div>
        <h2>Announcements</h2>
        <!-- Add your announcements component here -->
      </div>
    </div>
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
