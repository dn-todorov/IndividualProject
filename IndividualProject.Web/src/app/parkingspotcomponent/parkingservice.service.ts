import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { IParkingModel } from './parkingmodel';

@Injectable({
  providedIn: 'root'
})
export class ParkingService {
  constructor(private http: HttpClient) {}
  
  private apiUrl = 'http://localhost:32880/employee';

  
  getParkingSpot(): Observable<IParkingModel[]> {
    return this.http.get<IParkingModel[]>(this.apiUrl).pipe(
      map((data) => 
        data.map((item) => ({
          ...item,
          ...(item.car ? {
            carBrand: item.car.carBrand,
            registrationPlate: item.car.registrationPlate
          } : {
            carBrand: undefined,
            registrationPlate: undefined
          })
        }))
      )
    );
  }
}