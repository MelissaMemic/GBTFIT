import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProfilVM } from '../login/user';
import { AuthService } from 'src/app/services/auth.service';
import { KartaService } from 'src/app/services/karta.service';
import { KartaSnimiVM } from 'src/app/models/karta_snimi_model';
import { ApiService } from 'src/app/services/api.service';
import { HttpClient } from '@angular/common/http';

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
    private karta: KartaService,
    private router:Router,
    private apiService: ApiService,private http: HttpClient)
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

  }
  isPaymentOptionSelected() {
    return true
  }
  // finishBooking() {
  //   const karta = new KartaSnimiVM();
    
  //   karta.korisnikId = 1;  
  //   karta.Cijena = 123; 
  //   karta.DatumVoznje = this.selectedDepartureDate ? new Date(this.selectedDepartureDate) : new Date('2001-01-01');  
  //   karta.KlasaVoznje = this.selectedClass ? this.selectedClass : 'Druga'; 
  //   karta.KrajVoznje = this.selectedReturnTime || '19:00';  
  //   karta.Obrok = this.obrok;  
  //   karta.Popust = true;  
  //   karta.PocetakVoznje = this.selectedDepartureTime || '18:00'; 
  //   karta.Trajanje = '3 sata';  
    
  //   this.karta.snimi(karta);
  // }
  finishBooking() {
    const reservationData = {
        korisnikID: 1,  
        krajnjaDestinacijaID: this.selectedDestinations.end,
        pocetnaDestinacijaID: this.selectedDestinations.start,
        datumVoznje: new Date().toISOString(), 
        pocetakVoznje: this.selectedReturnTime,
        krajVoznje: this.selectedReturnTime,
        trajanje: '3h',
        klasaVoznje: 1,
        obrok: this.obrok !== null, 
        popust: true,  
        brojPerona: 2,
        cijena: 123, 
    };

    this.http.post('https://localhost:7219/Karta/Snimi', reservationData)
    .subscribe(
      response => {
        console.log('Reservation completed successfully:', response);
        this.router.navigate(['/home-page']);
      },
      error => {
        console.error('Error completing reservation:', error);
        // Handle error
      }
    );
  
  }
  searchOptions() {
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