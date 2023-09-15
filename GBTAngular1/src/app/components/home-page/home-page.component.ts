import { Component, OnDestroy ,OnInit} from '@angular/core';
import { Router } from '@angular/router';
import { interval, Subscription } from 'rxjs';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnDestroy, OnInit {
  images: string[] = [
    '../assets/img/slika1.jpg',
    '../assets/img/slika2.jpg',
    '../assets/img/slika3.jpg'
  ];
  
  currentImageIndex = 0;
  currentImage: string;
  lang:any;

  private subscription: Subscription;

  constructor(private router: Router) {
    this.currentImage = this.images[this.currentImageIndex];
    this.subscription = interval(3000).subscribe(() => this.changeBackgroundImage()); 
    // translate.setDefaultLang('de');

  }
  

  ngOnInit(){
    this.lang=localStorage.getItem('lang') || 'en';

  }
  changeLang(lang:any){
    localStorage.setItem('lang',lang);
    window.location.reload();
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }
  navigateToTicketBooking() {
    this.router.navigate(['/placanje']);
  }

  changeBackgroundImage() {
    this.currentImageIndex = (this.currentImageIndex + 1) % this.images.length;
    this.currentImage = this.images[this.currentImageIndex];
  }
}
