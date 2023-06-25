import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthGuard } from './guards/auth.guard';
import { ResetComponent } from './components/reset/reset.component';
import { ReservationViewComponent } from './reservation-view/reservation-view.component';
import { PaymentOptionsComponent } from './payment-options/payment-options.component';

const routes: Routes = [
  {path:'',redirectTo:'login',pathMatch:'prefix'},
  {path:'login', component:LoginComponent},
  {path:'signUp', component:SignupComponent},
  {path:'dashboard', component:DashboardComponent,canActivate: [AuthGuard]},
  {path:'reset', component:ResetComponent},
  { path: 'rezervacija', component: ReservationViewComponent },
  { path: 'placanje', component: PaymentOptionsComponent },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
