import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { AuthGuard } from './guards/auth.guard';
import { ResetComponent } from './components/reset/reset.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { PaymentOptionsComponent } from './components/payment-options/payment-options.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { TouristInfoComponent } from './components/tourist-info/tourist-info.component';
import { LiveTrackingComponent } from './components/live-tracking/live-tracking.component';

const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch:'prefix'},
  {path:'login', component:LoginComponent},
  {path:'signUp', component:SignupComponent},
  {path:'reset', component:ResetComponent},
  { path: 'rezervacija', component: ReservationViewComponent },
  { path: 'placanje', component: PaymentOptionsComponent },
  { path: 'home-page', component: HomePageComponent ,canActivate: [AuthGuard]},
  { path: 'tourist-info', component: TouristInfoComponent ,canActivate: [AuthGuard]},
  { path: 'live-tracking', component: LiveTrackingComponent },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
