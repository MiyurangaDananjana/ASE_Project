import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogInComponent } from './Components/pages/log-in/log-in.component';
import { SignUpComponent } from './Components/pages/sign-up/sign-up.component';
import { HomePageComponent } from './Components/pages/home-page/home-page.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material/material.module';
import { OtpLoginPageComponent } from './Components/pages/otp-login-page/otp-login-page.component';
import { CustomerDashbordComponent } from './Components/Components/customer-dashbord/customer-dashbord.component';
import { FormsModule,ReactiveFormsModule }   from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';





@NgModule({
  declarations: [
    AppComponent,
    LogInComponent,
    SignUpComponent,
    HomePageComponent,
    OtpLoginPageComponent,
    CustomerDashbordComponent,
    
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
