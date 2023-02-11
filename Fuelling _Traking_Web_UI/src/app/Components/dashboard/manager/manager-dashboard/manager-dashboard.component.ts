import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { user } from 'src/app/Service/user';
import { AuthService } from 'src/app/Service/auth.service';
import { NgToastService } from 'ng-angular-popup';
import { Chart, registerables } from 'node_modules/chart.js'

@Component({
  selector: 'app-manager-dashboard',
  templateUrl: './manager-dashboard.component.html',
  styleUrls: ['./manager-dashboard.component.css']
})
export class ManagerDashboardComponent implements OnInit {
  constructor(private route: ActivatedRoute, private loginAuth: AuthService, private router: Router, private toast: NgToastService) { }
  _fuelStationCode: any;

  _PhoneNumber: any = +94760743231;
  _chartData: any;
  _labeldata: any = [];
  _finisheddata: any = [];


  userPhoneNumber: { PhoneNumber?: any; } = {};

  ngOnInit(): void {
   this.RenderChart();
   this.dieselpiceCahrt();
    this.loginAuth.loadCurrentUser();
    this.loginAuth.currentUser.subscribe((data) => {
      this._fuelStationCode = data;
    })
  }

  
  // this is the pie chart fuel station fuel stock presant petrol
  RenderChart() {
    const myChart = new Chart("piechart1", {
      type: "pie",
      data: {
        labels: ["Tets","Test"],
        datasets: [{
          label: '# of Stock',
          data: [12,32],
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

  
  // this is the pie chart fuel station fuel stock presant diesal
  dieselpiceCahrt() {
    const myChart = new Chart("piechart2", {
      type: "pie",
      data: {
        labels: ["Tets","Test"],
        datasets: [{
          label: '# of Stock',
          data: [12,32],
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


}
