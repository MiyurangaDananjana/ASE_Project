import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'
import { ActivatedRoute, Router } from '@angular/router';

import { AuthService } from 'src/app/Service/auth.service';
import { NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-manager-login',
  templateUrl: './manager-login.component.html',
  styleUrls: ['./manager-login.component.css']
})
export class ManagerLoginComponent  implements OnInit {
  constructor(private route:ActivatedRoute, private loginAuth: AuthService, private router: Router,private toast: NgToastService) { }
  LoginForm:FormGroup;
  _fuelStationCode:any

  ngOnInit(): void {
    this.LoginForm = new FormGroup({
      FuelStationRegCode : new FormControl('',[Validators.required,Validators.minLength(0),Validators.maxLength(12)]),
      password : new FormControl('',[Validators.required,Validators.minLength(0),Validators.maxLength(12)])
    })
  }

  Submint(){
    this.loginAuth.managerLogin([
      this.LoginForm.value.FuelStationRegCode,
      this.LoginForm.value.password
    ]).subscribe(res =>{
    
      if(res == "NotFound"){
        this.toast.error({detail:"ERROR",summary:'Please check the phone number!',sticky:true});
      }
      else{

        this.loginAuth.setToken(res);
        this.router.navigateByUrl('/manager-dashboard')
        this.toast.success({detail:"SUCCESS",summary:'Successfully Otp send!',duration:5000});   
        
      }
    

    })
  }
  
}
