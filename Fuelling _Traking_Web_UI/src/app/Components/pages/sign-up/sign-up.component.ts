import { Component, OnInit } from '@angular/core';
import {FormGroup, FormControl, Validator, Validators} from '@angular/forms'
import { AuthService } from 'src/app/Service/auth.service';



@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {




  SingInForm : FormGroup;
  constructor(private loginAuth: AuthService) { }

  public VehicalType:any =[];
  public FuelStation:any =[];
  selectValue:any;



  ngOnInit(): void {

    this.SingInForm = new FormGroup({
      nic_number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      Phone_Number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      v_r_number : new FormControl('',[Validators.required,Validators.minLength(6)]),
      v_c_number: new FormControl('',[Validators.required,Validators.minLength(6)])
    })

   this.loginAuth.Get_Vehical_Type().subscribe((res)=> {
    this.VehicalType = res;
   });


   this.loginAuth.Get_Fuel_Station().subscribe((res)=> {
    this.FuelStation = res;
    console.log(this.FuelStation);
   });
    
  }

  changeClient(value:any) {
    console.log(value);
}

  Submint(){
    console.log(this.selectValue);
  }

}
