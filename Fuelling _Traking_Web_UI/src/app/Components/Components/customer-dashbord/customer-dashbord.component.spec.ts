import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerDashbordComponent } from './customer-dashbord.component';

describe('CustomerDashbordComponent', () => {
  let component: CustomerDashbordComponent;
  let fixture: ComponentFixture<CustomerDashbordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomerDashbordComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomerDashbordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
