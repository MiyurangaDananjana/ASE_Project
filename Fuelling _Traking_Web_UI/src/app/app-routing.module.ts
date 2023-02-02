import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LogInComponent } from './Components/pages/log-in/log-in.component';
import { HomePageComponent } from './Components/pages/home-page/home-page.component';
import { SignUpComponent } from './Components/pages/sign-up/sign-up.component';
import { OtpLoginPageComponent } from './Components/pages/otp-login-page/otp-login-page.component';
import { CustomerDashbordComponent } from './Components/Components/customer-dashbord/customer-dashbord.component';

import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { AlertsComponent } from './Components/alerts/alerts.component';
import { AccordionComponent } from './Components/accordion/accordion.component';
import { BadgesComponent } from './Components/badges/badges.component';
import { BreadcrumbsComponent } from './Components/breadcrumbs/breadcrumbs.component';
import { ButtonsComponent } from './Components/buttons/buttons.component';
import { CardsComponent } from './Components/cards/cards.component';
import { CarouselComponent } from './Components/carousel/carousel.component';
import { ChartsApexchartsComponent } from './Components/charts-apexcharts/charts-apexcharts.component';
import { ChartsChartjsComponent } from './Components/charts-chartjs/charts-chartjs.component';
import { FormsEditorsComponent } from './Components/forms-editors/forms-editors.component';
import { FormsElementsComponent } from './Components/forms-elements/forms-elements.component';
import { FormsLayoutsComponent } from './Components/forms-layouts/forms-layouts.component';
import { IconsBootstrapComponent } from './Components/icons-bootstrap/icons-bootstrap.component';
import { IconsBoxiconsComponent } from './Components/icons-boxicons/icons-boxicons.component';
import { IconsRemixComponent } from './Components/icons-remix/icons-remix.component';
import { ListGroupComponent } from './Components/list-group/list-group.component';
import { ModalComponent } from './Components/modal/modal.component';
import { PaginationComponent } from './Components/pagination/pagination.component';
import { ProgressComponent } from './Components/progress/progress.component';
import { SpinnersComponent } from './Components/spinners/spinners.component';
import { TablesDataComponent } from './Components/tables-data/tables-data.component';
import { TablesGeneralComponent } from './Components/tables-general/tables-general.component';
import { TabsComponent } from './Components/tabs/tabs.component';
import { TooltipsComponent } from './Components/tooltips/tooltips.component';
import { PagesBlankComponent } from './pages/pages-blank/pages-blank.component';
import { PagesContactComponent } from './pages/pages-contact/pages-contact.component';
import { PagesError404Component } from './pages/pages-error404/pages-error404.component';
import { PagesFaqComponent } from './pages/pages-faq/pages-faq.component';
import { PagesLoginComponent } from './pages/pages-login/pages-login.component';
import { PagesRegisterComponent } from './pages/pages-register/pages-register.component';
import { UsersProfileComponent } from './pages/users-profile/users-profile.component';

const routes: Routes = [

  {path:'', component:HomePageComponent},
  {path:'Sing-up', component:SignUpComponent},
  {path:'log-in', component:LogInComponent},
  {path:'otp-login', component:OtpLoginPageComponent},
  { path: 'dashboard', component: DashboardComponent },
  { path: 'alerts', component: AlertsComponent },
  { path: 'accordion', component: AccordionComponent },
  { path: 'badges', component: BadgesComponent },
  { path: 'breadcrumbs', component: BreadcrumbsComponent },
  { path: 'buttons', component: ButtonsComponent },
  { path: 'cards', component: CardsComponent },
  { path: 'carousel', component: CarouselComponent },
  { path: 'charts-apexcharts', component: ChartsApexchartsComponent },
  { path: 'charts-chartjs', component: ChartsChartjsComponent },
  { path: 'form-editors', component: FormsEditorsComponent },
  { path: 'form-elements', component: FormsElementsComponent },
  { path: 'form-layouts', component: FormsLayoutsComponent },
  { path: 'icons-bootstrap', component: IconsBootstrapComponent },
  { path: 'icons-boxicons', component: IconsBoxiconsComponent },
  { path: 'icons-remix', component: IconsRemixComponent },
  { path: 'list-group', component: ListGroupComponent },
  { path: 'modal', component: ModalComponent },
  { path: 'pagination', component: PaginationComponent },
  { path: 'progress', component: ProgressComponent },
  { path: 'spinners', component: SpinnersComponent },
  { path: 'tables-data', component: TablesDataComponent },
  { path: 'tables-general', component: TablesGeneralComponent },
  { path: 'tabs', component: TabsComponent },
  { path: 'tooltips', component: TooltipsComponent },
  { path: 'pages-blank', component: PagesBlankComponent },
  { path: 'pages-contact', component: PagesContactComponent },
  { path: 'pages-error404', component: PagesError404Component },
  { path: 'pages-faq', component: PagesFaqComponent },
  { path: 'pages-login', component: PagesLoginComponent },
  { path: 'pages-register', component: PagesRegisterComponent },
  { path: 'user-profile', component: UsersProfileComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
 