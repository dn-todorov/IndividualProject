import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParkingspotcomponentComponent } from './parkingspotcomponent.component';

describe('ParkingspotcomponentComponent', () => {
  let component: ParkingspotcomponentComponent;
  let fixture: ComponentFixture<ParkingspotcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ParkingspotcomponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ParkingspotcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
