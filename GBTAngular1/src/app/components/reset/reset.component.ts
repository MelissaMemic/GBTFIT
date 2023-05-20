import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NgToastComponent, NgToastService } from 'ng-angular-popup';
import { ConfirmPasswordValidator } from 'src/app/helpers/confirm-password.validator';
import { validateAllFormFields } from 'src/app/helpers/validateForm';
import { ResetPassword } from 'src/app/models/reset-password.model';
import { ResetPasswordService } from 'src/app/services/reset-password.service';

@Component({
  selector: 'app-reset',
  templateUrl: './reset.component.html',
  styleUrls: ['./reset.component.css']
})
export class ResetComponent implements OnInit{

resetPasswordForm!:FormGroup;
emailToReset!:string;
emailToken!:string;
resetPasswordObj= new ResetPassword();

constructor(private toast:NgToastService,
  private router:Router,
   private fb: FormBuilder,
   private activatedRoute:ActivatedRoute,
   private resetService:ResetPasswordService){

}

ngOnInit(): void {
  this.resetPasswordForm=this.fb.group({
    password:[null,Validators.required],
    confirmPassword:[null,Validators.required]
  },{
    validator:ConfirmPasswordValidator("password","confirmPassword")
  })
  this.activatedRoute.queryParams.subscribe(val=>{
    this.emailToReset=val['email'];
    let uriToken=val['code'];
    this.emailToken= uriToken.replace(/ /g,'+');

  })
}
reset(){
  if(this.resetPasswordForm.valid){
this.resetPasswordObj.email=this.emailToReset;
this.resetPasswordObj.newPassword=this.resetPasswordForm.value.password;
this.resetPasswordObj.confirmPassword=this.resetPasswordForm.value.confirmPassword;
this.resetPasswordObj.emailToken=this.emailToken;

this.resetService.resetPassword(this.resetPasswordObj).subscribe({
  next:(res)=>
  {
this.toast.success({
  detail:'SUCCESS',
  summary:"Password is set new!",
  duration:5000,
});
    this.router.navigate(['/'])
  },
  error:(err)=>{
    this.toast.error({
      detail:'ERROR',
      summary:"Password is NOT set new!",
      duration:5000,
    });
  }
})
  }else{
    validateAllFormFields(this.resetPasswordForm);
  }
}
}
