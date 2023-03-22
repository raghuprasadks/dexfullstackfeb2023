import { Component } from '@angular/core';

@Component({
  selector: 'app-simpleinterest',
  templateUrl: './simpleinterest.component.html',
  styleUrls: ['./simpleinterest.component.css']
})
export class SimpleinterestComponent {

  // Properties
  principal:number=0;
  roi:number=0;
  time:number=0
  si:number=0

  isDisabled=true
  isHidden=true

  // functionality
  CalculateSI():void{
  //  alert ('Inside calculate SI')
    console.log('Principal Amount ',this.principal)
    console.log('Roi Amount ',this.roi)
    console.log('time ',this.time)
    this.si = (this.principal*this.roi*this.time)/100
  }

}
