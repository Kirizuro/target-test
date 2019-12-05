<template>
  <v-app>
    <v-container>
      <v-row>
        <v-col align-center cols="12">
          <span>teste</span>
        </v-col>
      </v-row>
      <div id="app">
        <div id="nav">
          <router-link to="/">Home</router-link> |
          <router-link to="/about">About</router-link>
        </div>
        <router-view />
      </div>
    </v-container>
  </v-app>
</template>
