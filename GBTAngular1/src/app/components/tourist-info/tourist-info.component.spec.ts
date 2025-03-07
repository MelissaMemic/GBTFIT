import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TouristInfoComponent } from './tourist-info.component';

describe('TouristInfoComponent', () => {
  let component: TouristInfoComponent;
  let fixture: ComponentFixture<TouristInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TouristInfoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TouristInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
