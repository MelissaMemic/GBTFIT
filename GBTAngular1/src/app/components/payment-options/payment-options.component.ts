import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-placanje',
  templateUrl: './payment-options.component.html',
  styleUrls: ['./payment-options.component.css']
})
export class PaymentOptionsComponent {
  currentStep = 1;
  selectedDestinations: any = {};
  selectedDepartureDate: string = '';
  selectedReturnDate: string = '';
  isOneWay: boolean = false;
  ticketOptions: any = {};
  selectedClass: string = '';
  selectedSeat: string = '';
  selectedPaymentOption: string = '';
  selectedPaymentMethod: boolean=false;
  obrok: Boolean = false;
  isChecked: Boolean = false;
  
  nextStep() {
    this.currentStep++;
  }
  getProgressWidth() {
    return ((this.currentStep - 1) / 4) * 100 + '%';
  }
  selectStartDestination(event: Event,destination: string) {
    event.preventDefault();

    this.selectedDestinations.start = destination;
  }
  selectEndDestination(event: Event,destination: string) {
    event.preventDefault();
    this.selectedDestinations.end = destination;
  }
  areDestinationsSelected() {
    // return this.selectedDestinations.start && this.selectedDestinations.end;
    return true

  }
  isClassAndSeatSelected() {
    return true

    // return this.selectedClass && this.selectedSeat;
  }
  isPaymentOptionSelected() {
    // return this.selectedPaymentOption !== '';
    return true
  }
  finishBooking() {
    // Perform the final booking logic here
    console.log('Booking finished!');
  }
  searchOptions() {
    // Simulating search options
    this.ticketOptions = [
      {id:1,dateOfDeparture:'07:49', dateOfFinish:'19:00'},
      {id:2,dateOfDeparture:'09:49', dateOfFinish:'19:00'},
      {id:3,dateOfDeparture:'10:49', dateOfFinish:'19:00'},
      {id:4,dateOfDeparture:'17:49', dateOfFinish:'19:00'}];
  }
  toggleMeal() {
    this.isChecked = !this.isChecked;
  }
}