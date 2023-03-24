import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {

  @Input() msgToChild:string=''
  @Output() childEvent = new EventEmitter<string>();



  msgToParent(msg:string):void{

    this.childEvent.emit(msg)
  }

}
