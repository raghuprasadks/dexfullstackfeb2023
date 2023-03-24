import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {

  msg_to_child_from_parent:string = "hi child..how r u"
  msgFromChild:string = ""

  msgFromChildEvent($event:string):void{
    this.msgFromChild=$event;
  }

}
