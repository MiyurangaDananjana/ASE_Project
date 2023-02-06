import { Component } from '@angular/core';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'

@Component({
  selector: 'app-manager-login',
  templateUrl: './manager-login.component.html',
  styleUrls: ['./manager-login.component.css']
})
export class ManagerLoginComponent {
  
  LoginForm:FormGroup;
  
  ngOnInit(): void {

    this.LoginForm = new FormGroup({
      userName : new FormControl('',[Validators.required,Validators.minLength(12),Validators.maxLength(12)]),
      password : new FormControl('',[Validators.required,Validators.minLength(4),Validators.maxLength(4)])
    })
  }

  Submint(){
console.log(this.LoginForm.value)
  }
}
