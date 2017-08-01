import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';

import * as util from 'util';
import { Helper } from '../shared/sys/app-helper';

import { AuthStatus } from '../shared/sys/app-enums';
import { AppConstants } from '../shared/sys/app-constants';

import { Certification } from './certification.class';

@Injectable()
export class AuthService {
  authInfo: Certification;
  
  // store the URL so we can redirect after logging in
  redirectUrl: string;
  urlsAPI = {
    login: '',
    register: ''
  };

  constructor(private http: HttpClient) { 
    this.urlsAPI.login = AppConstants.ROOT_URI + '/Authentication/Login';
    this.urlsAPI.register = AppConstants.ROOT_URI + '/Authentication/Register';
  }

  login(username:string, password:string, successCallback, failCallback): void {
    this.authInfo = new Certification({username: username, password: password});
    var body = JSON.stringify(this.authInfo);
    Helper.InvokeAPIFull(this.urlsAPI.login, 'post', body, this.http)
      .subscribe(resp => {
        if (resp.body){          
          this.authInfo = new Certification(resp.body);
          localStorage.setItem('AuthInfo', JSON.stringify(this.authInfo));

          successCallback(this.authInfo);
        }
      },
      error => {
        failCallback(error);
      });
  }

  logout(): void {
    this.authInfo.status = AuthStatus.Logout; 
    this.authInfo.token = '';

    localStorage.setItem('AuthInfo', JSON.stringify(this.authInfo));
  }

  get IsLogin() {
    return this.authInfo != null && this.authInfo.status == AuthStatus.Login;
  }

  Vertify(): boolean {
    if (this.authInfo == null) {      
      var authData = localStorage.getItem('AuthInfo');
      if (authData == null) {
          return false;
      }
      else {
        this.authInfo = new Certification(JSON.parse(authData));
      }
    }    

    if (this.authInfo == null || this.authInfo.status !== AuthStatus.Login || this.authInfo.token === '')
      return false;


    if(this.authInfo.status == AuthStatus.Login){
      var today = new Date();
      if(today.getHours() - this.authInfo.loginDate.getHours() <= 24)
        return true;
    }

    return false;
  }

  register(username:string, password:string, successCallback, failCallback): void {
    this.authInfo = new Certification({username: username, password: password});
    var body = JSON.stringify(this.authInfo);
    Helper.InvokeAPIFull(this.urlsAPI.register, 'post', body, this.http)
      .subscribe(resp => {
        if (resp.body){
          successCallback(resp.body);
        }
      },
      error => {
        failCallback(error);
      });
  }

  test(): void {
    var body = JSON.stringify(this.authInfo);
    Helper.InvokeAPIFull(AppConstants.ROOT_URI + '/Users/Test', 'get', body, this.http, this.authInfo.token)
      .subscribe(resp => {
        if (resp.body){
          alert('');
        }
      },
      error => {
        
      });
  }
}
