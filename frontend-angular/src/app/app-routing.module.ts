import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeModule } from './home/home.module';
import { PostsModule } from './posts/posts.module';


const routes: Routes = [
  {
    path: 'home',
    component: HomeModule
  },
  {
    path: 'post',
    component: PostsModule
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
