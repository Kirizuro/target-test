<template>
  <v-app id="app">
    <v-content>
      <v-container fluid>
        <v-toolbar color="red" dark>
          <v-toolbar-title>Target Test</v-toolbar-title>

          <v-spacer></v-spacer>

          <v-toolbar-title>Posts CRUD System</v-toolbar-title>
        </v-toolbar>
        <v-row align-content="center" align="center" justify="center">
          <v-col class="text-center btn" cols="12">
            <v-btn to="/" color="primary">Home</v-btn>
            <v-btn class="btn" to="/create" exact color="secondary"
              >Criar Post</v-btn
            >
          </v-col>
        </v-row>
      </v-container>
      <div>
        <transition name="fade">
          <router-view></router-view>
        </transition>
      </div>
    </v-content>
  </v-app>
</template>

<script>
export default {
  computed: {
    route() {
      return this.$router.currentRoute.params;
    }
  }
};
</script>
<style>
.btn {
  margin: 0 0 0 10px;
}
</style>
