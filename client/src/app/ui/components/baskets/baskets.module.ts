import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketsComponent } from './baskets.component';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';



@NgModule({
  declarations: [
    BasketsComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path : "", component: BasketsComponent}
    ]),
    ToastrModule
    
  ]
})
export class BasketsModule { }


export class CenterPage {
  public message = "Warning";

}



