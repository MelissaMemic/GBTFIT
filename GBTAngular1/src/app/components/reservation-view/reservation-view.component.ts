import { Component } from '@angular/core';

@Component({
  selector: 'app-reservation-view',
  templateUrl: './reservation-view.component.html',
  styleUrls: ['./reservation-view.component.css']
})
export class ReservationViewComponent {
  departureDate: string = '2023-06-30';
  departureTime: string = '09:00';
  departureLocation: string = 'Sarajevo';
  destination: string = 'Zenica';
  seatNumber: string = '12A';
  passengerName: string = 'John Doe';
  class: string = 'Business';
}
