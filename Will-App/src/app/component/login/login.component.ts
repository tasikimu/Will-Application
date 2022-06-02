import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) {}

  loginForm: FormGroup | undefined;
  isSubmitted  =  false;
  public invalidLogin: boolean = false;

  login(){
    console.log(this.loginForm)
  }

  ngOnInit(): void {
    this.loginForm  =  this.formBuilder.group({
      UserName: ['', [Validators.required]],
      Password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(10)]]
  });

}
// get formControls() { return this.loginForm.controls; }

}
