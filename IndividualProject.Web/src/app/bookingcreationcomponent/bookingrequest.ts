import { Time } from "@angular/common";

export interface IBookingRequest {
    occupationDate: Date;
    parkingArrivalTime: Time;
    parkingDepartureTime: Time;
    note: string;
    employeeID: number;
    officeRoomID: number;
    parkingSpotID: number;
}