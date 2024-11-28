import { Component, OnInit} from '@angular/core';
import { ITrackingModel } from './trackingmodel';
import { OfficeBookingService } from './trackingservice.service';

@Component({
  selector: 'app-officebookingcomponent',
  templateUrl: './officebookingcomponent.component.html',
  styleUrl: './officebookingcomponent.component.css'
})
export class OfficeBookingcomponentComponent implements OnInit {
  public trackingData: ITrackingModel[] = [];

    constructor(
      private trackingservice: OfficeBookingService
    ){}

    ngOnInit() {
      this.trackingservice.getOfficeBookings().subscribe((model) => {
        this.trackingData = model;
      })
    }
}