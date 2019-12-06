import Vue from "vue";
import VueRouter from "vue-router";
import Home from "./components/postsHome.vue";
import Create from "./components/posts/components/Create.vue";
import Post from "./components/posts/components/Post.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "home",
    component: Home
  },
  {
    path: "/create",
    name: "create",
    component: Create
  },
  {
    path: "/post/:id",
    name: "post",
    component: Post
  },
  {
    path: "*",
    redirect: "/"
  }
];

const router = new VueRouter({
  mode: "history",
  base: process.env.BASE_URL,
  routes
});

export default router;
