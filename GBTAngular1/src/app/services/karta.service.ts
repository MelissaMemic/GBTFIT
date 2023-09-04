import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class KartaService {
private baseUrl:string="https://localhost:7219/Karta/";

constructor(private http : HttpClient) { }

snimi(karta:any){
  console.log(`${this.baseUrl}Snimi`);
  return this.http.post(`${this.baseUrl}Snimi`,karta); 
}
}
