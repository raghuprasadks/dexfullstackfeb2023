import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DatatypesComponent } from './datatypes/datatypes.component';
import { UserComponent } from './components/user/user.component';
import { SimpleinterestComponent } from './components/simpleinterest/simpleinterest.component';
import { FormsModule } from '@angular/forms';
import { TemplateformComponent } from './components/templateform/templateform.component'; 
import { HttpClientModule } from '@angular/common/http';
import { TodoComponent } from './components/todo/todo.component';
import { ChildComponent } from './components/child/child.component';
import { ParentComponent } from './components/parent/parent.component';

@NgModule({
  declarations: [
    AppComponent,
    DatatypesComponent,
    UserComponent,
    SimpleinterestComponent,
    TemplateformComponent,
    TodoComponent,
    ChildComponent,
    ParentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
