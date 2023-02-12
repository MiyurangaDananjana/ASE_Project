import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'
import { AuthService } from 'src/app/Service/auth.service';
import { NgToastService } from 'ng-angular-popup';

@Component({
  selector: 'app-otp-login-page',
  templateUrl: './otp-login-page.component.html',
  styleUrls: ['./otp-login-page.component.css']
})
export class OtpLoginPageComponent implements OnInit {

  constructor(private route:ActivatedRoute, private loginAuth: AuthService, private router: Router,private toast: NgToastService) { }
  LoginForm:FormGroup;
  phoneNumber:any;

  
  ngOnInit(): void {
    this.route.queryParams.subscribe((parms:any)=>{
      this.phoneNumber = parms.data; 
      
    })
    this.LoginForm = new FormGroup({
      PhoneNumber : new FormControl(this.phoneNumber,[Validators.required,Validators.minLength(12),Validators.maxLength(12)]),
      OtpCode : new FormControl('',[Validators.required,Validators.minLength(4),Validators.maxLength(4)])
 
    })
  }

  Submint(){
    this.loginAuth.chackCustomerOtp([
      this.LoginForm.value.PhoneNumber,
      this.LoginForm.value.OtpCode
    ]).subscribe(res =>{
      if(res == "OtpTure"){
        
        this.router.navigate(['/cus-dashboard'],{queryParams:{data:this.phoneNumber}})
        this.toast.success({detail:"SUCCESS",summary:'Logging successful',duration:5000});
      }
      else{
        this.toast.error({detail:"ERROR",summary:'Please enter a valid OTP code',sticky:true});
      }
    })
  }

}
