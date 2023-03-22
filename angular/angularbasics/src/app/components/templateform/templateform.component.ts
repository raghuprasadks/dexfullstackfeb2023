import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-templateform',
  templateUrl: './templateform.component.html',
  styleUrls: ['./templateform.component.css']
})
export class TemplateformComponent {
/**
  code:number=0;
  name:string="";
  sal:number=0


   */

  regusers:any[]=[];
  isDisabled=false
  isHidden=true
  msg:string=""

  RegisterEmployee(regForm:NgForm):void{

    console.log("form value")
    console.log(regForm.value)
    this.regusers.push(regForm.value)
  }
}
