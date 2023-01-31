import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OtpLoginPageComponent } from './otp-login-page.component';

describe('OtpLoginPageComponent', () => {
  let component: OtpLoginPageComponent;
  let fixture: ComponentFixture<OtpLoginPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OtpLoginPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OtpLoginPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
