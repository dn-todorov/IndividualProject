import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { ITrackingModel } from './trackingmodel';

@Injectable({
  providedIn: 'root'
})
export class OfficeBookingService {
  constructor(private http: HttpClient) {}
  
  private apiUrl = 'http://localhost:32880/track';

  
  getOfficeBookings(): Observable<ITrackingModel[]> {
    return this.http.get<ITrackingModel[]>(this.apiUrl).pipe(
      map((data) => 
        data.map((item) => ({
          ...item,
          date: new Date(item.occupationDate),
          firstName: item.employee.firstName,
          lastName: item.employee.lastName,
          teamName: item.employee.team.teamName,
          roomName: item.room.roomName,
          spotName: item.parkingSpot.spotName
        }))
      )
    );
  }
}