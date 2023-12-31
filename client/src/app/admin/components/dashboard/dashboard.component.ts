import { NgxSpinnerService } from 'ngx-spinner';
import { Component } from '@angular/core';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent extends BaseComponent {

  constructor(private alertify : AlertifyService, spinner : NgxSpinnerService) {
    super(spinner);
  }
    
    ngOnInit():void {

    }
  
  m() {
    this.alertify.message("Merhaba", {
      messageType: MessageType.Success,
      delay: 5,
      position: Position.TopRight
    });
  }

  d() {
    this.alertify.dismiss();
  }
}
