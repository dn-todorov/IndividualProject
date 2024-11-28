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

@NgModule({
  bootstrap: [AppComponent],
  declarations: [AppComponent,OfficeBookingcomponentComponent, TrackingappbarComponent, ParkingspotcomponentComponent],
  imports: [BrowserModule, BrowserAnimationsModule, CommonModule, GridModule, AppRoutingModule, HttpClientModule, 
    LayoutModule, IndicatorsModule, IconsModule, NavigationModule, ButtonsModule],
})
export class AppModule {}
