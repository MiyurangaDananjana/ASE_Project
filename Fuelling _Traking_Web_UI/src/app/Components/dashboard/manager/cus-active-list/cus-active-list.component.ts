
import { Component, ElementRef, OnInit } from '@angular/core';
import { AuthService } from 'src/app/Service/auth.service';
import { ActiveNonActiveList, Cus_Active_Non_ActiveList } from 'src/app/Service/user';
import { NgToastService } from 'ng-angular-popup';


@Component({
  selector: 'app-cus-active-list',
  templateUrl: './cus-active-list.component.html',
  styleUrls: ['./cus-active-list.component.css']
})
export class CusActiveListComponent implements OnInit {
  constructor(private loginAuth: AuthService, private toast: NgToastService) { }
  _fuelStationCode: any;
  nonActiveListObj: { FuelStationRegCode?: any, Statest?: any } = {}
  _Deactivate: { Id?: any, States?: any } = {}
  deleteCustomer: {}

  dataSource: Array<any> = [];
  ngOnInit(): void {
    this.loadDataSourese();
  }





  test(Id: any) {
    // alert(val);
    if (confirm('Are you sure'))
      this.loginAuth.deleteCustomer(Id).subscribe(
        (res: any) => {


          this.toast.error({ detail: "ERROR", summary: 'Please check the phone number!', sticky: true });
        },
        err => {
          this.loadDataSourese();
          this.toast.success({ detail: "SUCCESS", summary: 'Successfully Otp send!', duration: 5000 });

        }
      )

  }

  Deactivate(Id: any) {
    this._Deactivate.Id = Id;
    this._Deactivate.States = 1;

    this.loginAuth.deactive(this._Deactivate as unknown as Cus_Active_Non_ActiveList).subscribe((res: any) => {
      if (res == 'Success') {
        this.loadDataSourese();
        this.toast.success({ detail: "SUCCESS", summary: 'Successfully Deactive Customer!', duration: 5000 });
        this.ngOnInit();
      }
      else {
        this.toast.error({ detail: "ERROR", summary: 'Non Deactive Please Contact IT Team!', sticky: true });
      }


    }


    )

  }

  loadDataSourese() {
    this.loginAuth.loadCurrentUser();
    this.loginAuth.currentUser.subscribe((data: any) => {
      this._fuelStationCode = data;
    });

    this.nonActiveListObj.Statest = 2;
    this.nonActiveListObj.FuelStationRegCode = this._fuelStationCode.FuelStationRegCode

    this.loginAuth.getNonActiveList(this.nonActiveListObj as unknown as ActiveNonActiveList).subscribe((res: any) => {
      this.dataSource = res;
    });

  }
}
