import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { NgToastModule } from 'ng-angular-popup';
import { TokenInterceptor } from './components/interceptors/token.interceptor';
import { ResetComponent } from './components/reset/reset.component';
import { ReservationViewComponent } from './components/reservation-view/reservation-view.component';
import { PaymentOptionsComponent } from './components/payment-options/payment-options.component';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { HomePageComponent } from './components/home-page/home-page.component';
import { TouristInfoComponent } from './components/tourist-info/tourist-info.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    ResetComponent,
    ReservationViewComponent,
    PaymentOptionsComponent,
    HomePageComponent,
    TouristInfoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgToastModule,
    FormsModule,
    SlickCarouselModule,

  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:TokenInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
