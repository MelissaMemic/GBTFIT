import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProfilVM } from '../login/user';
import { AuthService } from 'src/app/services/auth.service';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-placanje',
  templateUrl: './payment-options.component.html',
  styleUrls: ['./payment-options.component.css']
})
export class PaymentOptionsComponent implements OnInit {
  currentStep = 1;
  selectedDestinations = { start: "", end: "" };
    selectedDepartureDate: string = '';
  selectedDepartureTime: string = '';
  selectedReturnTime: string = '';
  selectedReturnDate: string = '';
  isOneWay: boolean = false;
  ticketOptions: any = {};
  stanice: any[] = [];
  Startstanice: any[] = [];
  Endstanice: any[] = [];
  selectedClass: string = '';
  selectedSeat: string = '';
  selectedPaymentOption: string = '';
  selectedPaymentMethod: boolean=false;
  obrok: Boolean = false;
  isChecked: Boolean = false;
  user: ProfilVM = new ProfilVM;
  IsStartDestination:Boolean=false;
  selectedStanica: any;

  constructor(
    private auth: AuthService,
    private router:Router,
    private apiService: ApiService)
    {  
        // translate.setDefaultLang('de'); 
  }
  ngOnInit(): void {
    this.apiService.getStanice().subscribe((stanice) => {
      this.Startstanice = stanice;
      this.Endstanice = stanice;
    });

  }

  onStartDestinationChange() {
    const startId = parseInt(this.selectedDestinations.start, 10); 
    const isStartDestination = true; 
  
    if (!isNaN(startId)) {
      this.apiService.getStaniceById(startId, isStartDestination).subscribe((endStations) => {
        this.Endstanice = endStations;
      });
    } else {
      this.Endstanice = []; 
    }
  

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

    // this.dataService.getData().subscribe((data) => {
    //   this.data = data;
    // });
    // Simulating search options
    // this.ticketOptions = [
    //   {id:1,dateOfDeparture:'07:49', dateOfFinish:'19:00'},
    //   {id:2,dateOfDeparture:'09:49', dateOfFinish:'19:00'},
    //   {id:3,dateOfDeparture:'10:49', dateOfFinish:'19:00'},
    //   {id:4,dateOfDeparture:'17:49', dateOfFinish:'19:00'}];

    // selectedDepartureDate
    const startDestination = parseInt(this.selectedDestinations.start, 10); 
    const endDestination = parseInt(this.selectedDestinations.end, 10); 
   this.apiService.getVoznjeInfo(this.selectedDepartureDate, startDestination,endDestination).subscribe((voznje) => {
    this.ticketOptions = voznje;
      });

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