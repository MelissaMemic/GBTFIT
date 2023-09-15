import { Component, OnDestroy ,OnInit} from '@angular/core';
import { interval, Subscription } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-tourist-info',
  templateUrl: './tourist-info.component.html',
  styleUrls: ['./tourist-info.component.css']
})
export class TouristInfoComponent implements OnDestroy,OnInit{
  images: string[] = [
    '../assets/img/miljacka.jpg',
    '../assets/img/kafa.jpg',
    '../assets/img/sarajevo.jpg'
  ]

  images2: string[] = [
    '../assets/img/smokva.jpg',
    '../assets/img/buna.jpg',
    '../assets/img/mostar.jpg'
  ]

  currentImageIndex = 0;
  currentImage1: string;
  currentImage2: string;
  lang:any;


  private subscription: Subscription;

  constructor(private router: Router) {
    this.currentImage1 = this.images[this.currentImageIndex];
    this.currentImage2 = this.images2[this.currentImageIndex];
    this.subscription = interval(5000).subscribe(() => this.changeBackgroundImage());
  }

  ngOnInit(){
    this.lang=localStorage.getItem('lang') || 'en';

  }
  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  changeBackgroundImage() {
    this.currentImageIndex = (this.currentImageIndex + 1) % this.images.length;
    this.currentImage1 = this.images[this.currentImageIndex];
    this.currentImage2 = this.images2[this.currentImageIndex];
  }
}
