import { Component, ViewChild, ViewEncapsulation } from "@angular/core";
import { FormGroup, FormControl } from "@angular/forms";
import { TextBoxComponent } from "@progress/kendo-angular-inputs";
import { SVGIcon, eyeIcon } from "@progress/kendo-svg-icons";


@Component({
  selector: 'app-bookingcreationcomponent',
  templateUrl: './bookingcreationcomponent.component.html',
  styleUrl: './bookingcreationcomponent.component.css'
})
export class BookingcreationcomponentComponent {
  @ViewChild("password") public textbox: TextBoxComponent;
  public eye: SVGIcon = eyeIcon;

  public ngAfterViewInit(): void {
    this.textbox.input.nativeElement.type = "password";
  }


  public form: FormGroup = new FormGroup({
    firstName: new FormControl(),
    lastName: new FormControl(),
    parkingSpot: new FormControl(),
    roomNumber: new FormControl(),
    datePicker: new FormControl()
  });

  public submit(): void {
    this.form.markAllAsTouched();
  }

  public clearForm(): void {
    this.form.reset();
  }
}
