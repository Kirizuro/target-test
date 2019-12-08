<template>
  <v-container>
    <v-row align="center">
      <v-col class="text-center" cols="12">
        <v-form>
          <v-text-field
            label="Titulo"
            v-model="post.title"
            required
          ></v-text-field>
          <v-text-field
            label="Descrição"
            v-model="post.description"
            required
          ></v-text-field>
        </v-form>
        <v-btn @click="updatePost">Atualizar</v-btn>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { api } from "../../../services/api";

export default {
  name: "post",

  data() {
    return {
      post: [],
      title: "",
      description: ""
    };
  },

  methods: {
    postId() {
      return this.$router.currentRoute.params.id;
    },

    async getPost() {
      try {
        const result = await api.post(`/showId`, {
          _id: this.postId()
        });

        this.post = await result.data.post;
      } catch (error) {
        return error;
      }
    },

    async updatePost() {
      try {
        await api.put(`/update`, {
          _id: this.postId(),
          title: this.post.title,
          description: this.post.description
        });

        this.$router.go(-1);
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
