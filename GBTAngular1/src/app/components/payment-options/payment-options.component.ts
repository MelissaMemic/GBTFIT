import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProfilVM } from '../login/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-placanje',
  templateUrl: './payment-options.component.html',
  styleUrls: ['./payment-options.component.css']
})
export class PaymentOptionsComponent implements OnInit {
  currentStep = 1;
  selectedDestinations: any = {};
  selectedDepartureDate: string = '';
  selectedDepartureTime: string = '';
  selectedReturnTime: string = '';
  selectedReturnDate: string = '';
  isOneWay: boolean = false;
  ticketOptions: any = {};
  selectedClass: string = '';
  selectedSeat: string = '';
  selectedPaymentOption: string = '';
  selectedPaymentMethod: boolean=false;
  obrok: Boolean = false;
  isChecked: Boolean = false;
  user: ProfilVM = new ProfilVM;

  constructor(
    private auth: AuthService,
    private router:Router)
    {}
  ngOnInit(): void {
    //this.auth.getProfil().subscribe({
    //  next: (res) => {
    //    this.user = res as ProfilVM;
    //    console.log(res);
    //  }
    //});
  }
  nextStep() {
    this.currentStep++;
  }
  getProgressWidth() {
    return ((this.currentStep - 1) / 4) * 100 + '%';
  }
  selectStartDestination(event: Event, destination: string) {
    event.preventDefault();

    this.selectedDestinations.start = destination;
  }
  selectEndDestination(event: Event, destination: string) {
    event.preventDefault();
    this.selectedDestinations.end = destination;
  }
  selectClass(event: Event, destination: string) {
    event.preventDefault();

    this.selectedClass = destination;
    console.log(this.selectedClass);
  }
  selectSeat(event: Event, destination: string) {
    event.preventDefault();

    this.selectedSeat = destination;
  }
  //selectClass(event: Event, class: string) {
  //  event.preventDefault();
  //  this.selectClass = class;
  //}
  //selectSeat(event: Event, seat: string) {
  //  event.preventDefault();
  //  this.selectSeat = seat;
  //}
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
  togglePayment(check: Boolean) {
    this.isChecked = check;
    this.selectedPaymentOption = this.isChecked == true ? "Kartica" : "Gotovina";
  }
  saveSeat() {
    console.log(this.selectSeat);
  }
  toggleMeal() {
    this.obrok = !this.obrok;
  }
  AddDepartureTicket(id : number) {
    this.selectedDepartureDate = this.selectedDepartureDate.substring(0, this.selectedDepartureDate.indexOf('T'));
    this.selectedReturnDate = this.selectedReturnDate.substring(0, this.selectedReturnDate.indexOf('T'));
    this.selectedDepartureTime = this.ticketOptions[id].dateOfDeparture;
    this.selectedReturnTime = this.ticketOptions[id].dateOfFinish;
    this.nextStep();
  }
}