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
import { FormsModule,ReactiveFormsModule }   from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './Service/auth.service';
import { NgToastModule } from 'ng-angular-popup';
import { NgChartsModule } from 'ng2-charts';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { CusNavigationComponent } from './Components/dashboard/cus-navigation/cus-navigation.component';
import { CusDashboardComponent } from './Components/dashboard/cus-dashboard/cus-dashboard.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule } from '@angular/material/card';
import { MatMenuModule } from '@angular/material/menu';
import { QRCodeModule } from 'angularx-qrcode';
import { ManagerLoginComponent } from './Components/pages/manager-login/manager-login.component';
import { AdminLoginComponent } from './Components/pages/admin-login/admin-login.component';
import { ManagerDashboardComponent } from './Components/dashboard/manager/manager-dashboard/manager-dashboard.component';
import { ManagerFooterComponent } from './Components/dashboard/manager/manager-footer/manager-footer.component';
import { ManagerHeaderComponent } from './Components/dashboard/manager/manager-header/manager-header.component';
import { ManagerSidebarComponent } from './Components/dashboard/manager/manager-sidebar/manager-sidebar.component';
import { ManagerComponentsComponent } from './Components/dashboard/manager/manager-components/manager-components.component';



@NgModule({
  declarations: [
    AppComponent,
    LogInComponent,
    SignUpComponent,
    HomePageComponent,
    OtpLoginPageComponent,
    CusNavigationComponent,
    CusDashboardComponent,
    ManagerLoginComponent,
    AdminLoginComponent,
    ManagerDashboardComponent,
    ManagerFooterComponent,
    ManagerHeaderComponent,
    ManagerSidebarComponent,
    ManagerComponentsComponent



  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    HttpClientModule,
    NgToastModule,
    NgChartsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    QRCodeModule
  

  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
