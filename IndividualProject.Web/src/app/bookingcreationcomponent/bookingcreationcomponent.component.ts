import { Component, ViewChild, ViewEncapsulation } from "@angular/core";
import { FormGroup, FormControl, FormBuilder, Validators } from "@angular/forms";
import { TextBoxComponent } from "@progress/kendo-angular-inputs";
import { SVGIcon, eyeIcon } from "@progress/kendo-svg-icons";
import { OfficeBookingService } from "./bookingcreationservice.service";
import { IRoomModel } from "./officeroommodel";
import { IParkingModel } from "./parkingspotmodel";
import { IEmployeeModel } from "./employeemodel";


@Component({
  selector: 'app-bookingcreationcomponent',
  templateUrl: './bookingcreationcomponent.component.html',
  styleUrl: './bookingcreationcomponent.component.css'
})
export class BookingcreationcomponentComponent {
  @ViewChild("password") public textbox: TextBoxComponent;
  public eye: SVGIcon = eyeIcon;

  public roomData: IRoomModel[] = [];

  public parkingData: IParkingModel[] = [];

  public employeeData: IEmployeeModel[] = [];

  public selectedDate: Date | null = null;

  public  myForm: FormGroup;

  public ngAfterViewInit(): void {
    this.textbox.input.nativeElement.type = "password";
  }

  constructor(
    private creationservice: OfficeBookingService,
    private fb: FormBuilder
  ){
      this.myForm = this.fb.group({
        occupationDate: null,
        parkingArrivalTime: null,
        parkingDepartureTime: null,
        note: '',
        employeeID: null,
        officeRoomID: null,
        parkingSpotID: null
      });
  }

  // public form: FormGroup = new FormGroup({
  //   firstName: new FormControl(),
  //   lastName: new FormControl(),
  //   occupationDate: new FormControl(),
  //   officeRoomID: new FormControl(),
  //   employeeID: new FormControl(),
  //   parkingSpotID: new FormControl()
  // });

  public submit(): void {
      if(this.myForm.valid){
        const formData = this.myForm.value;
        const requestBody = {
          occupationDate: formData.occupationDate.toISOString().split('T')[0],
          parkingArrivalTime: formData.parkingArrivalTime.toTimeString().slice(0,5),
          parkingDepartureTime: formData.parkingDepartureTime.toTimeString().slice(0,5),
          note: formData.note,
          employeeID: formData.employeeID.id,
          officeRoomID: formData.officeRoomID.id,
          parkingSpotID: formData.parkingSpotID.id
        };
        this.creationservice.sendDataToAPI(requestBody).subscribe();
        console.log("here");
        console.log(requestBody);
        this.creationservice.sendDataToAPI(requestBody);
    }else{
      console.log("Form is invalid");
    }
  }

  public clearForm(): void {
    this.myForm.reset();
  }

  ngOnInit() {
    this.creationservice.getOfficeRooms().subscribe((model) => {
      this.roomData = model;
    })
    this.creationservice.getParkingSpots().subscribe((model) => {
      this.parkingData = model;
    })
    this.creationservice.getEmployees().subscribe((model) => {
      this.employeeData = model;
    })
  }
}
