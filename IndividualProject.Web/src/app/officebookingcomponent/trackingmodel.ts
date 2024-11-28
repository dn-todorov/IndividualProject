import { Time } from "@angular/common";
import { NumberValueAccessor } from "@angular/forms";

export interface ITrackingModel {
    id: number;
    occupationDate: Date;
    parkingArrivalTime: Time;
    parkingDepartureTime: Time;
    note: string;
    room: Room;
    employee: Employee;
    parkingSpot: ParkingSpot;
  }

interface Room {
  id: number;
  roomName: string;
}

interface ParkingSpot {
  id: number;
  spotName: string;
}

interface Employee {
  id: number;
  firstName: string;
  lastName: string;
  team: Team;
}

interface Team {
  id: number;
  teamName: string;
}