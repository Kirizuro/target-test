<template>
  <v-container>
    <v-row align="center" justify="center">
      <v-col v-for="post in posts" :key="post._id" cols="12" lg="3">
        <v-card>
          <v-card-title>{{ post.title }}</v-card-title>
          <v-card-text>{{ post.description }}</v-card-text>
          <v-card-actions>
            <v-btn @click="deletePost(post._id)" color="error" text
              >Excluir</v-btn
            >
            <v-spacer></v-spacer>
            <v-btn
              :to="{ name: 'post', params: { id: post._id } }"
              color="primary"
              text
              >Editar</v-btn
            >
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { api } from "../services/api";

export default {
  name: "home",

  data() {
    return {
      posts: []
    };
  },

  methods: {
    async getPost() {
      try {
        const result = await api.get(`/show`);
        this.posts = result.data.posts;
      } catch (error) {
        return error;
      }
    },
    async deletePost(id) {
      try {
        await api.delete(`/${id}`, {
          data: {
            _id: id
          }
        });
        this.getPost();
      } catch (error) {
        return error;
      }
    }
  },

  mounted() {
    this.getPost();
  }
};
</script>
