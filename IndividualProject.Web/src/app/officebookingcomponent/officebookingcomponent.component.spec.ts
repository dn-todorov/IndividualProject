import { ComponentFixture, TestBed } from '@angular/core/testing';
import { OfficeBookingcomponentComponent } from './officebookingcomponent.component';

describe('OfficebookingcomponentComponent', () => {
  let component: OfficeBookingcomponentComponent;
  let fixture: ComponentFixture<OfficeBookingcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [OfficeBookingcomponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(OfficeBookingcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
