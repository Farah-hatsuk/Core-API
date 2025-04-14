import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryComponent } from './NewFolder/category/category.component';
import { AddCategoryComponent } from './NewFolder/add-category/add-category.component';
import { EditCategoryComponent } from './NewFolder/edit-category/edit-category.component';

const routes: Routes = [
  { path: "category", component: CategoryComponent },
  { path: "addCategory", component: AddCategoryComponent },
  { path: "editCategory/:id", component: EditCategoryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
