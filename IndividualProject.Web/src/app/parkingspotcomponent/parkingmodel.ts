export interface IParkingModel {
    id: number;
    firstName: string;
    lastName: string;
    car: Car;
  }

interface Car {
    id: number;
    carBrand: string;
    registrationPlate: string;
}