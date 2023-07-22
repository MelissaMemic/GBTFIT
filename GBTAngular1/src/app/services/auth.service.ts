import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { TokenApiModel } from '../models/token-api.model';
import { ProfilVM } from '../components/login/user';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
private baseUrl:string="https://localhost:7219/Autentification/";
  constructor(private http : HttpClient ,private router: Router) { }

signUp(signUpObject:any){
  return this.http.post<any>(`${this.baseUrl}register`,signUpObject); 
}

storeRefreshToken(tokenValue:string){
  localStorage.setItem('refreshToken',tokenValue)

}

login(loginObj:any){
  return this.http.post<any>(`${this.baseUrl}Login`,loginObj); 
}
signOut(){
  localStorage.clear();
this.router.navigate(['login'])

}
storeToken(tokenValue:string){
  localStorage.setItem('token',tokenValue)
}
getToken(){
  return localStorage.getItem('token')
}
getRefreshedToken(){
  return localStorage.getItem('refreshToken')
}
getProfil() {
  return this.http.get(`${this.baseUrl}GetProfil`);
}
isLoggedIn():boolean{
return !!localStorage.getItem('token')
}
renewToken(tokenApi: TokenApiModel){
return this.http.post<any>(`${this.baseUrl}refresh`,tokenApi)
}
}
