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
import { LiveTrackingComponent } from './components/live-tracking/live-tracking.component';
import { AgmCoreModule } from '@agm/core';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';


 import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import {  HttpClient } from '@angular/common/http';
import { TicketOverviewComponent } from './components/ticket-overview/ticket-overview.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignupComponent,
    ResetComponent,
    ReservationViewComponent,
    PaymentOptionsComponent,
    HomePageComponent,
    TouristInfoComponent,
    LiveTrackingComponent,
    TicketOverviewComponent
  ],
  imports: [
   // TranslateModule.forRoot(),
    BrowserModule,
    // TranslateModule.forRoot({
    //     loader: {
    //         provide: TranslateLoader,
    //         useFactory: HttpLoaderFactory,
    //         deps: [HttpClient],
    //     },
    // }),
    AppRoutingModule,
   

    ReactiveFormsModule,
    HttpClientModule,
    NgToastModule,
    FormsModule,
    SlickCarouselModule,CommonModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyDLrCrNK5uXTFkdoOr7P2IX-JMMlfFdm3E',
      libraries: ['places']

    })

  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:TokenInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})


export class AppModule { }
// export function HttpLoaderFactory(http: HttpClient) {
//   return new TranslateHttpLoader(http, './assets/i18n/', '.json');
//}