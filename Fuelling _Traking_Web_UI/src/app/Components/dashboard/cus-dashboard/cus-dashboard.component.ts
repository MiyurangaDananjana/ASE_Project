import { Component, OnInit } from '@angular/core';
import { map } from 'rxjs/operators';
import { Breakpoints, BreakpointObserver } from '@angular/cdk/layout';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Service/auth.service';
import { user } from 'src/app/Service/user';
import { __values } from 'tslib';
import { Chart, registerables } from 'node_modules/chart.js'
import { SafeUrl } from '@angular/platform-browser';


@Component({
  selector: 'app-cus-dashboard',
  templateUrl: './cus-dashboard.component.html',
  styleUrls: ['./cus-dashboard.component.css']
})
export class CusDashboardComponent implements OnInit {
  constructor(private breakpointObserver: BreakpointObserver, private route: ActivatedRoute, private loginAuth: AuthService) {

  }
  /** Based on the screen size, switch from standard to one column per row */
  _PhoneNumber: any;
  _chartData: any;
  _labeldata: any = [];
  _finisheddata: any = [];
  myAngularQRcode: any;
  _QRCode: any;


  userPhoneNumber: { PhoneNumber?: any; } = {};


  ngOnInit(): void {
    this.route.queryParams.subscribe((parms: any) => {
      this._PhoneNumber = parms.data;
    });

    this.userPhoneNumber.PhoneNumber = String(this._PhoneNumber) //convert to int value string and pass servic 


    this.loginAuth.getStock(this.userPhoneNumber as unknown as user).subscribe((res: any) => {
      this._chartData = res;
      //set the responce data to array
      if (this._chartData != null) {
        for (let i = 0; i < this._chartData.length; i++) {
          // console.log(this._chartData[i]);
          this._labeldata.push(Object.keys(this._chartData[i])[1]);
          this._labeldata.push(Object.keys(this._chartData[i])[2]);
          this._finisheddata.push(Object.values(this._chartData[i])[1]);
          this._finisheddata.push(Object.values(this._chartData[i])[2]);
        }
        this.RenderChart(this._labeldata, this._finisheddata, 'pie', 'piechart');
      };
    });
    
    this.qrGodeGetAndSet();
  };


  
  qrGodeGetAndSet() {
    this.loginAuth.getQrCode(this.userPhoneNumber as unknown as user).subscribe((res: any) => {
      this._QRCode = res;
      this.myAngularQRcode = this._QRCode;
    });
  }


  // this is the pie chart fuel station fuel stock presant
  RenderChart(labeldata: any, maindata: any, type: any, id: any) {
    const myChart = new Chart(id, {
      type: type,
      data: {
        labels: labeldata,
        datasets: [{
          label: '# of Stock',
          data: maindata,
          backgroundColor: ['Blue', 'white'],
          borderColor: [
            'rgba(255, 99, 132, 1)'
          ],
          borderWidth: 1
        }]
      },
      options: {
        scales: {
          y: {
            beginAtZero: true
          }
        }
      }
    });

  };


  
  // qr code genarator
  url: SafeUrl = ''
  onCodeChange(url: SafeUrl) {
    this.url = url;
  }

}
