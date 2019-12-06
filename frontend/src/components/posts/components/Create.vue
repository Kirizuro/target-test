<template>
  <v-container>
    <v-row class="text-center" align="center">
      <v-col cols="12" lg="12">
        <h1>Criar post</h1>
        <v-text-field label="Titulo" v-model="title" required></v-text-field>
        <v-text-field
          label="Descrição"
          v-model="description"
          required
        ></v-text-field>
        <v-btn @click="createPost" color="primary">Criar</v-btn>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { api } from "../../../services/api";

export default {
  name: "create",

  data() {
    return {
      title: "",
      description: ""
    };
  },

  methods: {
    async createPost() {
      try {
        await api.post(`/create`, {
          title: this.title,
          description: this.description
        });

        this.$router.go(-1);
      } catch (error) {
        return error;
      }
    }
  }
};
</script>
