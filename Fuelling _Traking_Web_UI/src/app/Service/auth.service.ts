import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { user, ActiveNonActiveList,Cus_Active_Non_ActiveList } from './user';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  currentUser: BehaviorSubject<any> = new BehaviorSubject(null);
  baseServerURL = 'http://localhost:61475/api/';
  jwtHelperService = new JwtHelperService();



  Get_Vehical_Type() {
    return this.http.get(this.baseServerURL + 'NewCustomer/GetVehical', { responseType: 'json' });
  }
  Get_Fuel_Station() {
    return this.http.get(this.baseServerURL + 'NewCustomer/Fuel-Station', { responseType: 'json' })
  }
  Save_Customer_Req(customeDetail: Array<String>) {
    return this.http.post(this.baseServerURL + 'NewCustomer/Req-customer', {
      NicNumber: customeDetail[0],
      PhoneNumber: customeDetail[1],
      VehicalRegNumber: customeDetail[2],
      VehicalChassisNumber: customeDetail[3],
      FuelId: customeDetail[4],
      FuelStation: customeDetail[5]
    }, { responseType: 'text' });
  }
  phoneNumberValidation(phoneNumebr: Array<String>) {
    return this.http.post(this.baseServerURL + 'NewCustomer/sent-otp', {
      PhoneNumber: phoneNumebr[0]
    }, { responseType: 'text' })
  }

  managerLogin(loginDetails: Array<String>) {
    return this.http.post(this.baseServerURL + 'Manager/manager-login-auth', {
      FuelStationRegCode: loginDetails[0],
      Password: loginDetails[1]
    }, { responseType: 'text' })
  };

  getStock(userPhoneNumber: user) {
    return this.http.post(this.baseServerURL + 'NewCustomer/cus-stock-chack',
      {
        PhoneNumber: userPhoneNumber.PhoneNumber
      }
      ,
      {
        responseType: 'json'
      })
  }

  getQrCode(userPhoneNumber: user) {
    return this.http.post(this.baseServerURL + 'NewCustomer/get-qr-code', {
      PhoneNumber: userPhoneNumber.PhoneNumber
    }, {
      responseType: 'text'
    })
  }

  chackCustomerOtp(chackOtp: Array<String>) {
    return this.http.post(this.baseServerURL + 'NewCustomer/Otp-chack', {
      PhoneNumber: chackOtp[0],
      OtpCode: chackOtp[1],
    }, {
      responseType: 'text'
    })
  };

  setToken(token: string) {
    localStorage.setItem("access_token", token);
    this.loadCurrentUser();
  };


  loadCurrentUser() {
    const token = localStorage.getItem("access_token");
    const userInfo = token != null ? this.jwtHelperService.decodeToken(token) : null;
    const data = userInfo ? {
      FuelStationRegCode: userInfo.FuelStationRegCode
    } : null;
    this.currentUser.next(data);
  };

  isLoggedin(): boolean {
    return localStorage.getItem("access_token") ? true : false;
  }



  getNonActiveList(FuelCodeAndStatest: ActiveNonActiveList) {
    return this.http.post(this.baseServerURL + 'Manager/cus-req',
      {
        FuelStationRegCode: FuelCodeAndStatest.FuelStationRegCode,
        Statest: FuelCodeAndStatest.Statest
      }
      ,
      {
        responseType: 'json'
      })
  }

  //---customer deactivate ---//
  deactive(deactive:Cus_Active_Non_ActiveList){
    return this.http.put(this.baseServerURL+'Manager/update-active-nonActive-cus',
    {
      Id:deactive.Id,
      States:deactive.States

    },
    {
      responseType: 'text'
    }
    
    )
  }

  //----delete customer ------//
  deleteCustomer(Id:any) {
    return this.http.delete(this.baseServerURL + 'Manager/delete-cus/' + Id)
  }

  //---remove token -----//

  removeToken(){
    localStorage.removeItem("access_token");
  }



}
