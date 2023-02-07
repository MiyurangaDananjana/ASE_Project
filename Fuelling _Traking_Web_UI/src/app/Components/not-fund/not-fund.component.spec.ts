import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NotFundComponent } from './not-fund.component';

describe('NotFundComponent', () => {
  let component: NotFundComponent;
  let fixture: ComponentFixture<NotFundComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NotFundComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NotFundComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
