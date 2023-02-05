import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { user } from './user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }
  currentUser: BehaviorSubject<any> = new BehaviorSubject(null);
  baseServerURL = 'http://localhost:61475/api/';
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
  }
}
