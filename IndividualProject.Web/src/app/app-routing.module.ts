import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OfficeBookingcomponentComponent } from './officebookingcomponent/officebookingcomponent.component';

const routes: Routes = [{path:'./officebooking', component: OfficeBookingcomponentComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
