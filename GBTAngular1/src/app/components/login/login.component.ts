import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

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
constructor(private fb:FormBuilder, private auth: AuthService,private router:Router){}

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
    alert("Melii you are loged");
              this.loginForm.reset();
              this.router.navigate(['dashboard']);

  },error:(err)=>{
    alert("Access denied bro ")
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
}
