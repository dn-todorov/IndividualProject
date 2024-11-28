import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OfficeBookingcomponentComponent } from './officebookingcomponent/officebookingcomponent.component';
import { ParkingspotcomponentComponent } from './parkingspotcomponent/parkingspotcomponent.component';

const routes: Routes = [{path:'officebooking', component: OfficeBookingcomponentComponent},
  {path:'parkingspot', component: ParkingspotcomponentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
