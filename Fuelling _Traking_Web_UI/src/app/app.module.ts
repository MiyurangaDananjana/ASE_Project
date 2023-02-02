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

import { HeaderComponent } from './layouts/header/header.component';
import { FooterComponent } from './layouts/footer/footer.component';
import { SidebarComponent } from './layouts/sidebar/sidebar.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { AlertsComponent } from './Components/alerts/alerts.component';
import { AccordionComponent } from './Components/accordion/accordion.component';
import { BadgesComponent } from './Components/badges/badges.component';
import { BreadcrumbsComponent } from './Components/breadcrumbs/breadcrumbs.component';
import { ButtonsComponent } from './Components/buttons/buttons.component';
import { CardsComponent } from './Components/cards/cards.component';
import { CarouselComponent } from './Components/carousel/carousel.component';
import { ListGroupComponent } from './Components/list-group/list-group.component';
import { ModalComponent } from './Components/modal/modal.component';
import { TabsComponent } from './Components/tabs/tabs.component';
import { PaginationComponent } from './Components/pagination/pagination.component';
import { ProgressComponent } from './Components/progress/progress.component';
import { SpinnersComponent } from './Components/spinners/spinners.component';
import { TooltipsComponent } from './Components/tooltips/tooltips.component';
import { FormsElementsComponent } from './Components/forms-elements/forms-elements.component';
import { FormsLayoutsComponent } from './Components/forms-layouts/forms-layouts.component';
import { FormsEditorsComponent } from './Components/forms-editors/forms-editors.component';
import { TablesGeneralComponent } from './Components/tables-general/tables-general.component';
import { TablesDataComponent } from './Components/tables-data/tables-data.component';
import { ChartsChartjsComponent } from './Components/charts-chartjs/charts-chartjs.component';
import { ChartsApexchartsComponent } from './Components/charts-apexcharts/charts-apexcharts.component';
import { IconsBootstrapComponent } from './Components/icons-bootstrap/icons-bootstrap.component';
import { IconsRemixComponent } from './Components/icons-remix/icons-remix.component';
import { IconsBoxiconsComponent } from './Components/icons-boxicons/icons-boxicons.component';
import { UsersProfileComponent } from './pages/users-profile/users-profile.component';
import { PagesFaqComponent } from './pages/pages-faq/pages-faq.component';
import { PagesContactComponent } from './pages/pages-contact/pages-contact.component';
import { PagesRegisterComponent } from './pages/pages-register/pages-register.component';
import { PagesLoginComponent } from './pages/pages-login/pages-login.component';
import { PagesError404Component } from './pages/pages-error404/pages-error404.component';
import { PagesBlankComponent } from './pages/pages-blank/pages-blank.component';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    LogInComponent,
    SignUpComponent,
    HomePageComponent,
    OtpLoginPageComponent,
    CustomerDashbordComponent,
    HeaderComponent,
    FooterComponent,
    SidebarComponent,
    DashboardComponent,
    AlertsComponent,
    AccordionComponent,
    BadgesComponent,
    BreadcrumbsComponent,
    ButtonsComponent,
    CardsComponent,
    CarouselComponent,
    ListGroupComponent,
    ModalComponent,
    TabsComponent,
    PaginationComponent,
    ProgressComponent,
    SpinnersComponent,
    TooltipsComponent,
    FormsElementsComponent,
    FormsLayoutsComponent,
    FormsEditorsComponent,
    TablesGeneralComponent,
    TablesDataComponent,
    ChartsChartjsComponent,
    ChartsApexchartsComponent,
    IconsBootstrapComponent,
    IconsRemixComponent,
    IconsBoxiconsComponent,
    UsersProfileComponent,
    PagesFaqComponent,
    PagesContactComponent,
    PagesRegisterComponent,
    PagesLoginComponent,
    PagesError404Component,
    PagesBlankComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    HttpClientModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
