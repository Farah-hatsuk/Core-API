import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryComponent } from './NewFolder/category/category.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AddCategoryComponent } from './NewFolder/add-category/add-category.component';
import { EditCategoryComponent } from './NewFolder/edit-category/edit-category.component';
import { DashboardComponent } from './Admin/dashboard/dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    NavbarComponent,
    AddCategoryComponent,
    EditCategoryComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
