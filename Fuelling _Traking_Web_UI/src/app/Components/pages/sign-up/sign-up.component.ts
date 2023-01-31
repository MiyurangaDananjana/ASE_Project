import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'

interface Food {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  SingInForm : FormGroup;
  constructor() { }



  ngOnInit(): void {

    this.SingInForm = new FormGroup({
      nic_number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      Phone_Number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      v_r_number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      v_c_number: new FormControl('',[Validators.required,Validators.minLength(6)])
    })
    
  }
  foods: Food[] = [
    {value: 'steak-0', viewValue: 'Steak'},
    {value: 'pizza-1', viewValue: 'Pizza'},
    {value: 'tacos-2', viewValue: 'Tacos'},
  ];

  Submint(){
    console.log(this.SingInForm);
  }

}
