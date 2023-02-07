import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/Service/auth.service';

@Component({
  selector: 'app-not-fund',
  templateUrl: './not-fund.component.html',
  styleUrls: ['./not-fund.component.css']
})
export class NotFundComponent implements OnInit {
  _fuelStationCode:any;
  constructor(private loginAuth: AuthService) { }

  ngOnInit(): void {
    this.loginAuth.currentUser.subscribe((data:any)=>{
      this._fuelStationCode = data;
      console.log(this._fuelStationCode);
    });
  }

}
