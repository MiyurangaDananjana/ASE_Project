import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerComponentsComponent } from './manager-components.component';

describe('ManagerComponentsComponent', () => {
  let component: ManagerComponentsComponent;
  let fixture: ComponentFixture<ManagerComponentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagerComponentsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagerComponentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
