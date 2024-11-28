import { IParkingModel } from './parkingmodel';
import { Component, OnInit } from '@angular/core';
import { ParkingService } from './parkingservice.service';

@Component({
  selector: 'app-parkingspotcomponent',
  templateUrl: './parkingspotcomponent.component.html',
  styleUrl: './parkingspotcomponent.component.css'
})
export class ParkingspotcomponentComponent implements OnInit {
  public parkingSpot: IParkingModel[] = [];

    constructor(
      private parkingservice: ParkingService
    ){}

    ngOnInit() {
      this.parkingservice.getParkingSpot().subscribe((model) => {
        this.parkingSpot = model;
        console.log(this.parkingSpot);
      })
    }
}
