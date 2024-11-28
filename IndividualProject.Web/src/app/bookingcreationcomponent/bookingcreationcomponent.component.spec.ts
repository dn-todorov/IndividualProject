import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookingcreationcomponentComponent } from './bookingcreationcomponent.component';

describe('BookingcreationcomponentComponent', () => {
  let component: BookingcreationcomponentComponent;
  let fixture: ComponentFixture<BookingcreationcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [BookingcreationcomponentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BookingcreationcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
