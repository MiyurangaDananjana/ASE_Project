import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LogInComponent } from './Components/pages/log-in/log-in.component';
import { HomePageComponent } from './Components/pages/home-page/home-page.component';
import { SignUpComponent } from './Components/pages/sign-up/sign-up.component';
import { OtpLoginPageComponent } from './Components/pages/otp-login-page/otp-login-page.component';
import { CusNavigationComponent } from './Components/dashboard/cus-navigation/cus-navigation.component';
import { ManagerLoginComponent } from './Components/pages/manager-login/manager-login.component';
import { AdminLoginComponent } from './Components/pages/admin-login/admin-login.component';
import { ManagerDashboardComponent } from './Components/dashboard/manager/manager-dashboard/manager-dashboard.component';
import { ManagerComponentsComponent } from './Components/dashboard/manager/manager-components/manager-components.component';




const routes: Routes = [

  {path:'', component:HomePageComponent},
  {path:'Sing-up', component:SignUpComponent},
  {path:'log-in', component:LogInComponent},
  {path:'otp-login', component:OtpLoginPageComponent},
  {path:'cus-dashboard', component:CusNavigationComponent},
  {path:'manager-login',component:ManagerLoginComponent},
  {path:'admin-login',component:AdminLoginComponent},
  {path:'manager-dashboard',component:ManagerDashboardComponent},
  {path:'cus-req',component:ManagerComponentsComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
 