import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl:string="https://localhost:7219/";
  private voznjeUrl:string="https://localhost:7219/Voznja/";
  private staniceUrl:string="https://localhost:7219/Stanica/";
  private ticketUrl = 'https://localhost:7219/Karta/'; 

  constructor(private http:HttpClient) { }

  getUsers(){
   return this.http.get<any>(this.baseUrl);
  }


// getStaniceById(vm: any): Observable<any[]> {
//   return this.http.get<any[]>(`${this.staniceUrl}GetStaniceById`, vm);
// }
getTicketsByUserId(userId: number): Observable<any[]> {
  const url = `${this.ticketUrl}GetByKorisnikId/${userId}`;
  return this.http.get<any[]>(url);
}

getStaniceById(startId: number, isStartDestination: boolean): Observable<any[]> {
  const vm = { id: startId, IsStartDestination: isStartDestination };

  return this.http.get<any[]>(`${this.baseUrl}GetStaniceById`, { params: vm });
}
getStanice(): Observable<any[]> {
  return this.http.get<any[]>(`${this.staniceUrl}GetStanice`);
}
getVoznjeInfo(datumPolaska:string, polaznaStanica:number,povratnaStanica:number): Observable<any[]> {

  const polaznaStanicaStr = polaznaStanica.toString();
  const povratnaStanicaStr = povratnaStanica.toString();

  const params = {
    datumPolaska: datumPolaska,
    polaznaStanica: polaznaStanicaStr,
    povratnaStanica: povratnaStanicaStr
  };

  return this.http.get<any[]>(`${this.voznjeUrl}GetVoznjeInfo`, { params });
}

}
