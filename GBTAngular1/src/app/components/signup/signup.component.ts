import { Component,OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
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

    constructor(private sf:FormBuilder,private auth: AuthService,private router: Router){
  
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
      this.auth.signUp(this.signUpForm.valid).subscribe({
        next:(res)=>{
          alert("Successfuly signed up ");
          this.signUpForm.reset();
          this.router.navigate(['dashboard']);
        },
        error:(err)=>{
          alert("Access Denied for signup");
        }
      })

    }else{
//throw error
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
  