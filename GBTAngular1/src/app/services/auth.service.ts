import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
private baseUrl:string="https://localhost:7183/api/User/";
  constructor(private http : HttpClient ) { }

signUp(signUpObject:any){
  return this.http.post<any>(`${this.baseUrl}register`,signUpObject); 
}

login(loginObj:any){
  return this.http.post<any>(`${this.baseUrl}authenticate`,loginObj); 
}

}