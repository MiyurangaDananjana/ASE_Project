import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerFuelReqComponent } from './manager-fuel-req.component';

describe('ManagerFuelReqComponent', () => {
  let component: ManagerFuelReqComponent;
  let fixture: ComponentFixture<ManagerFuelReqComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagerFuelReqComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagerFuelReqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
