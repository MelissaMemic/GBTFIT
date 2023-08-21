import { Component,OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgToastService } from 'ng-angular-popup';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit{
  type:string="password";
  isText:boolean=false;
  eyeIcon: string="fa-eye-slash";
  signUpForm!:FormGroup;

    constructor(
      private sf:FormBuilder,
      private auth: AuthService,
      private router: Router,
      private toast:NgToastService){
  
  }
  ngOnInit(): void {
    this.signUpForm=this.sf.group({
      firstName:['',Validators.required],
      lastName:['',Validators.required],
      email:['',Validators.required],
      password:['',Validators.required],
      userName:['',Validators.required]
    })
    
  }
  hideShowPass(){
  this.isText= !this.isText;
  this.isText ? this.eyeIcon="fa-eye":this.eyeIcon="fa-eye-slash";
  this.isText ? this.type="text":this.type="password";
  }
  onSignUp(){
    if(this.signUpForm.valid){
      this.auth.signUp(this.signUpForm.value).subscribe({
        next:(res)=>{
          this.signUpForm.reset();
          this.toast.success({detail:"SUCCESS", summary:res.message, duration:5000});
          this.router.navigate(['dashboard']);
        },
        error:(err)=>{
          this.toast.error({detail:"ERROR", summary:"Something went wrong!", duration:5000});
        }
      })

    }else{
  this.validateAllFormFields(this.signUpForm);
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

  }
  