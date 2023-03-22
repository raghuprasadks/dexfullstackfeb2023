import { Component } from '@angular/core';

@Component({
  selector: 'app-datatypes',
  templateUrl: './datatypes.component.html',
  styleUrls: ['./datatypes.component.css']
})
export class DatatypesComponent {
// type script
  coursename:string="Angular"
  duration:number=4;
  coursedetails={
    topic:'Introduction',
    assignment:'Create a new component'
  }

  topics:string[]=['Installation of libraries','create a new project']

  test:any='any data type can be assigned'

}
