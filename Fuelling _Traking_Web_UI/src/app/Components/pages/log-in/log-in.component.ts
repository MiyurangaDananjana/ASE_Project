import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'
import { AuthService } from 'src/app/Service/auth.service';
import { NgToastService } from 'ng-angular-popup';
import { Router } from '@angular/router';


@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  constructor(private loginAuth: AuthService,private toast: NgToastService , private route: Router) { }

  OtpForm : FormGroup;
  phoneNumber:any;
  ngOnInit(): void {

    this.OtpForm = new FormGroup({
      PhoneNumber : new FormControl('+94',[Validators.required,Validators.minLength(12),Validators.maxLength(12)])
    })

  }
  IsAccountCreated: boolean = false;
  Submint(){
    this.loginAuth.phoneNumberValidation([
      this.OtpForm.value.PhoneNumber
    ]).subscribe(res =>{
      if(res == '201'){
        
        this.phoneNumber = this.OtpForm.value.PhoneNumber;
        // console.log(this.OtpForm.value.PhoneNumber)
        this.route.navigate(['/otp-login'],{queryParams:{data:this.phoneNumber}})

        this.toast.success({detail:"SUCCESS",summary:'Successfully Otp send!',duration:5000});
        this.IsAccountCreated = true;
      }
      else{
        this.toast.error({detail:"ERROR",summary:'Please check the OTP code!',sticky:true});
        this.IsAccountCreated = false;
        console.log(res)
      }
    })
  }

}
