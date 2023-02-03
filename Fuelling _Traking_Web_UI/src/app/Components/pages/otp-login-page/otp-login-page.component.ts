import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'

@Component({
  selector: 'app-otp-login-page',
  templateUrl: './otp-login-page.component.html',
  styleUrls: ['./otp-login-page.component.css']
})
export class OtpLoginPageComponent implements OnInit {

  constructor(private route:ActivatedRoute) { }
  LoginForm:FormGroup;
  phoneNumber:any;
  ngOnInit(): void {

    
    this.route.queryParams.subscribe((parms:any)=>{
      console.log(parms);
      this.phoneNumber = parms.data; 
      console.log(this.phoneNumber);
    })

    this.LoginForm = new FormGroup({
      PhoneNumber : new FormControl(this.phoneNumber,[Validators.required,Validators.minLength(12),Validators.maxLength(12)])
      
    
    })
    

  }

  Submint(){

  }

}
