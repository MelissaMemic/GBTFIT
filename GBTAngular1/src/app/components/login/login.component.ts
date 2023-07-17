import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { AuthService } from 'src/app/services/auth.service';
import { ResetPasswordService } from 'src/app/services/reset-password.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{
type:string="password";
isText:boolean=false;
eyeIcon: string="fa-eye-slash";
loginForm!: FormGroup;
public resetPasswordEmail!:string;
public isValidEmail!:boolean;

constructor(
  private fb:FormBuilder, 
  private auth: AuthService,
  private router:Router,
  private toast: NgToastService,
  private reset: ResetPasswordService)
  {}
  
  ngOnInit(): void {
    this.loginForm = this.fb.group({
    username: ['',Validators.required],
    password:['',Validators.required]
  })

  }
  hideShowPass(){
  this.isText= !this.isText;
  this.isText ? this.eyeIcon="fa-eye":this.eyeIcon="fa-eye-slash";
  this.isText ? this.type="text":this.type="password";
  }

  onLogin(){
    if(this.loginForm.valid){
//send obj to DBmmememem

this.auth.login(this.loginForm.value).subscribe({
  next:(res)=>{
              this.loginForm.reset();
              this.auth.storeToken(res.accessToken);
              this.auth.storeRefreshToken(res.refreshToken);
              this.toast.success({detail:"SUCCESS!", summary:res.message,duration:5000});
              this.router.navigate(['home-page']);

  },error:(err)=>{    
              this.toast.error({detail:"ERROR", summary:"Something went wrong!",duration:5000});
  }
})
    }else{
//throw error
this.validateAllFormFields(this.loginForm);
    }
  }

  private validateAllFormFields(formGroup:FormGroup){
Object.keys(formGroup.controls).forEach(field=>{
  const control= formGroup.get(field);
  if(control instanceof FormControl){
    control.markAsDirty({onlySelf:true});
  }else if(control instanceof FormGroup){
    this.validateAllFormFields(control);
  }
})
  }
  checkValidEmail(event:string){
    const value=event;
    const pattern= /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/;
    this.isValidEmail=pattern.test(value);
    return this.isValidEmail;
  }
  confirmToSend(){
    if(this.checkValidEmail(this.resetPasswordEmail)){
      console.log(this.resetPasswordEmail)

      this.reset.sendRestPasswordLink(this.resetPasswordEmail).subscribe({
        next:(res)=>{
          this.toast.success({
            detail:'Success',
            summary:'Successfuly reset of password!',
            duration:5000,
          });
          this.resetPasswordEmail="";
          const buttonRef=document.getElementById("closeBtn");
          buttonRef?.click();
        },
        error:(err)=>
        {
          this.toast.error({
            detail:'ERROR',
            summary:'Something went wrong!',
            duration:5000,
          });

        }
      })
    }
  }

}
