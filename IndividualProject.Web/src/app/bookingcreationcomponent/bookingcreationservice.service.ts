import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { IParkingModel } from './parkingspotmodel';
import { IRoomModel } from './officeroommodel';
import { IEmployeeModel } from './employeemodel';
import { IBookingRequest } from './bookingrequest';

@Injectable({
  providedIn: 'root'
})
export class OfficeBookingService {
    constructor(private http: HttpClient) {}
  
    private apiUrlOffice = 'http://localhost:32880/officeroom';
    private apiUrlParking = 'http://localhost:32880/parking';
    private apiUrlEmployee = 'http://localhost:32880/employee';
    private requestModelBooking = 'http://localhost:32880/track/add';
  
  getParkingSpots(): Observable<IParkingModel[]> {
    return this.http.get<IParkingModel[]>(this.apiUrlParking).pipe(
      map((data) => 
        data.map((item) => ({
          ...item
        }))
      )
    );
  }

  getOfficeRooms(): Observable<IRoomModel[]> {
    return this.http.get<IRoomModel[]>(this.apiUrlOffice).pipe(
      map((data) => 
        data.map((item) => ({
          ...item
        }))
      )
    );
  }

  getEmployees(): Observable<IEmployeeModel[]> {
    return this.http.get<IEmployeeModel[]>(this.apiUrlEmployee).pipe(
      map((data) => 
        data.map((item) => ({
          ...item,
          fullName: item.firstName + ' ' + item.lastName
        }))
      )
    );
  }


  sendDataToAPI(data:any):Observable<IBookingRequest>{
    console.log(data);
    return this.http.post<IBookingRequest>(this.requestModelBooking, data);
  }
}