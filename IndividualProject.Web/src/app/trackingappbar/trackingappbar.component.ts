import { Component } from '@angular/core';
import { KENDO_NAVIGATION } from '@progress/kendo-angular-navigation';
import { bellIcon, menuIcon, SVGIcon } from "@progress/kendo-svg-icons";

@Component({
  selector: 'app-trackingappbar',
  templateUrl: './trackingappbar.component.html',
  styleUrl: './trackingappbar.component.css'
})
export class TrackingappbarComponent {
  public menuIcon: SVGIcon = menuIcon;
  public bellIcon: SVGIcon = bellIcon;
  public kendokaAvatar = "assets/navigation/appbar/kendoka-angular.png";
}
