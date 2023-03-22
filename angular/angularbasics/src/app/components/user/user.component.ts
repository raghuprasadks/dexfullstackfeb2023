import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {

  users=[
    {
      code:1,
      name:'ravi',
      location:'chennai',
      isActive:false

    },
    {
      code:2,
      name:'gowri',
      location:'pune',
      isActive:true

    },
    {
      code:3,
      name:'srinivas',
      location:'bengaluru',
      isActive:true
    }
]

  constructor(){

    console.log("UserComponent:constructor")

  }
  ngOnInit(): void {
    console.log("UserComponent:ngOnInit")
  }

  

}
