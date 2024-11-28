import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackingappbarComponent } from './trackingappbar.component';

describe('TrackingappbarComponent', () => {
  let component: TrackingappbarComponent;
  let fixture: ComponentFixture<TrackingappbarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TrackingappbarComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TrackingappbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
