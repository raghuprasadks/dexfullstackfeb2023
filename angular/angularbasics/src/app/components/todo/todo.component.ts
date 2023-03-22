import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Todo } from 'src/app/models/todo';
import { TodoService } from 'src/app/services/todo.service';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css']
})
export class TodoComponent implements OnInit{

 // todos:any[]=[]
 todos:Todo[]=[]
  constructor(private todoService:TodoService){

  }
  ngOnInit(): void {
    this.todoService.getTodos().subscribe((todos)=>{
      console.log("todos from service")

      console.log(todos)
      this.todos=todos
    })
  }

  AddTodos(todoForm:NgForm):void{

    console.log("form value")
    console.log(todoForm.value)
    let todo:Todo  = todoForm.value;
    this.todoService.addTodos(todo).subscribe((todo)=>{
      console.log("todo response from server ",todo)
    }) 
   // this.regusers.push(regForm.value)
  }
}
