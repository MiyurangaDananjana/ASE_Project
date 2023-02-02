import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http:HttpClient) { }
  currentUser: BehaviorSubject<any> = new BehaviorSubject(null);
  baseServerURL ='http://localhost:61475/api/';



  Get_Vehical_Type(){
    return this.http.get(this.baseServerURL+'NewCustomer/GetVehical',{responseType:'json'});
  }

  Get_Fuel_Station(){
    return this.http.get(this.baseServerURL+'NewCustomer/Fuel-Station',{responseType:'json'})
  }
}
