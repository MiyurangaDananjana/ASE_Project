import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CusActiveListComponent } from './cus-active-list.component';

describe('CusActiveListComponent', () => {
  let component: CusActiveListComponent;
  let fixture: ComponentFixture<CusActiveListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CusActiveListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CusActiveListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
