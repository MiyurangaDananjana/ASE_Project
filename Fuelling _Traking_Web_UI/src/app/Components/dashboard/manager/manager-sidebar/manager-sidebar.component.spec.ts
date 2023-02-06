import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerSidebarComponent } from './manager-sidebar.component';

describe('ManagerSidebarComponent', () => {
  let component: ManagerSidebarComponent;
  let fixture: ComponentFixture<ManagerSidebarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagerSidebarComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagerSidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
