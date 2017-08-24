import { Component, Injectable } from '@angular/core';
import { Router, NavigationExtras } from '@angular/router';

import  { AuthService } from '../auth.service';

import {BaseComponent} from '../../shared/base/base.component';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {MdDialog} from '@angular/material';

import { FormState } from '../../shared/sys/app-enums';

@Component({
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

@Injectable()
export class LoginComponent extends BaseComponent {
  message = '';

  username: string;
  password: string;
  formstate = FormState.View;

  get IsLogin() { 
    return this.authService.authInfo;
  }
  get IsCreating(){
    return this.formstate == FormState.Create;
  }

  constructor(public authService: AuthService, public router: Router, httpClient: HttpClient, dialog: MdDialog) {
    super(httpClient, dialog);
  }

  login() {
    this.authService.login(this.username, this.password, (data)=>{
      var redirect = this.authService.redirectUrl ? this.authService.redirectUrl : '/dashboard';
      var navigationExtras: NavigationExtras = {
        queryParamsHandling: 'preserve',
        preserveFragment: true
      };

      this.router.navigate([redirect], navigationExtras);
    },
    (error)=>{
      if (error.status == '500') {
        this.message = error.error.items[0].message;
      }
    });
  }

  logout() {
    this.authService.logout();
  }

  register(){
    this.authService.register(this.username, this.password, (data)=>{
      var redirect = this.authService.redirectUrl ? this.authService.redirectUrl : '/login';
      var navigationExtras: NavigationExtras = {
        queryParamsHandling: 'preserve',
        preserveFragment: true
      };

      this.router.navigate([redirect], navigationExtras);
    },
    (error)=>{
      if (error.status == '500') {
        this.message = error.error.items[0].message;
      }
    });
  }

  changeState(formState: string){
    this.formstate = FormState[formState];
  }

  test(){
    super.SetMode(FormState.Waiting);
    this.authService.test();
  }
}
