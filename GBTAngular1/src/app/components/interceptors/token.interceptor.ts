import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, catchError, switchMap, throwError } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { NgToastService } from 'ng-angular-popup';
import { Router } from '@angular/router';
import { TokenApiModel } from 'src/app/models/token-api.model';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {

  constructor(private auth : AuthService,private toast:NgToastService,private route:Router) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    const myToken=this.auth.getToken();
    if(myToken){
      request=request.clone({
        setHeaders:{Authorization:`Bearer ${myToken}`}
      })
    }
    return next.handle(request).pipe(
      catchError((err:any)=>{
      if(err instanceof HttpErrorResponse){
        if(err.status==401){
          // this.toast.warning({detail:"Warning",summary:"This token is expired, Login again!"});
          // this.route.navigate(['login']);
         return this.handleUnAuthorizedError(request,next)
        }
      }
      return throwError(()=>err)
    }));
  }
  handleUnAuthorizedError(req:HttpRequest<any>, next:HttpHandler){
    let tokenApiModel= new TokenApiModel();
    tokenApiModel.accessToken=this.auth.getToken()!;
    tokenApiModel.refreshToken=this.auth.getRefreshedToken()!;
    return this.auth.renewToken(tokenApiModel)
    .pipe(
      switchMap((data:TokenApiModel)=>{
      this.auth.storeRefreshToken(data.refreshToken);
      this.auth.storeToken(data.accessToken);
      req=req.clone({
        setHeaders:{Authorization:`Bearer ${data.accessToken}`}
      })
      return next.handle(req)
    }),
    catchError((err)=>{
      return throwError(()=>
      {
        this.toast.warning({detail:"Warning",summary:"This token is expired, Login again!"});
        this.route.navigate(['login']);

      })
    })
    )
  }
}
