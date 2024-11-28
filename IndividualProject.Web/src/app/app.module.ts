import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { GridModule } from '@progress/kendo-angular-grid';

import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { CommonModule } from "@angular/common";

import { OfficeBookingcomponentComponent } from './officebookingcomponent/officebookingcomponent.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { TrackingappbarComponent } from './trackingappbar/trackingappbar.component';


import { LayoutModule } from "@progress/kendo-angular-layout";
import { IndicatorsModule } from "@progress/kendo-angular-indicators";
import { IconsModule } from "@progress/kendo-angular-icons";
import { NavigationModule } from "@progress/kendo-angular-navigation";

import { ButtonsModule } from "@progress/kendo-angular-buttons";
import { ParkingspotcomponentComponent } from './parkingspotcomponent/parkingspotcomponent.component';
import { BookingcreationcomponentComponent } from './bookingcreationcomponent/bookingcreationcomponent.component';

import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { DateInputsModule } from "@progress/kendo-angular-dateinputs";
import { LabelModule } from "@progress/kendo-angular-label";
import { InputsModule } from "@progress/kendo-angular-inputs";
import { DropDownListComponent } from '@progress/kendo-angular-dropdowns';

@NgModule({
  bootstrap: [AppComponent],
  declarations: [AppComponent,OfficeBookingcomponentComponent, TrackingappbarComponent, ParkingspotcomponentComponent, BookingcreationcomponentComponent],
  imports: [BrowserModule, BrowserAnimationsModule, CommonModule, GridModule, AppRoutingModule, HttpClientModule, 
    LayoutModule, IndicatorsModule, IconsModule, NavigationModule, ButtonsModule, FormsModule, ReactiveFormsModule, DateInputsModule, LabelModule, InputsModule, DropDownListComponent],
})
export class AppModule {}
