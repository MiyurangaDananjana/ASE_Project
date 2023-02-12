import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validator, Validators } from '@angular/forms'
import { AuthService } from 'src/app/Service/auth.service';
import { NgToastService } from 'ng-angular-popup';



@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  SingInForm: FormGroup;
  constructor(private loginAuth: AuthService, private toast: NgToastService) { }

  public VehicalType: any = [];
  public FuelStation: any = [];
  selectValue: any;

  ngOnInit(): void {

    this.SingInForm = new FormGroup({
      NicNumber: new FormControl('', [Validators.required, Validators.minLength(12)]),
      PhoneNumber: new FormControl('', [Validators.required, Validators.minLength(12), Validators.maxLength(12)]),
      VehicalRegNumber: new FormControl('', [Validators.required, Validators.minLength(5)]),
      VehicalChassisNumber: new FormControl('', [Validators.required, Validators.minLength(6)]),
      FuelId: new FormControl('', [Validators.required]),
      FuelStation: new FormControl('', [Validators.required])

    })

    this.loginAuth.Get_Vehical_Type().subscribe((res) => {
      this.VehicalType = res;
    });

    this.loginAuth.Get_Fuel_Station().subscribe((res) => {
      this.FuelStation = res;
      console.log(this.FuelStation);
    });

  }

  //Select Fueu station id 
  FuelStationId(value: any) {
    console.log(value);
  }

  //Select vahical type id
  VahicleTypeId(value: any) {
    console.log(value);
  }

  IsAccountCreated: boolean = false;
  Submint() {

    console.log(this.SingInForm.value);
    this.loginAuth.Save_Customer_Req([
      this.SingInForm.value.NicNumber,
      this.SingInForm.value.PhoneNumber,
      this.SingInForm.value.VehicalRegNumber,
      this.SingInForm.value.VehicalChassisNumber,
      this.SingInForm.value.FuelId,
      this.SingInForm.value.FuelStation
    ]).subscribe(res => {

      if (res == '201') {
        this.toast.success({ detail: "Account created successfully", summary: 'Successfully created!', duration: 5000 });
        this.IsAccountCreated = true;
      }
      else if (res == '415') {
        this.toast.error({ detail: "ERROR", summary: 'Already used the registration number', sticky: true, duration: 5000 });
        this.IsAccountCreated = false;
        console.log(res)
      }
    })

  }

}
