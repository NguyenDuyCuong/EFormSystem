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
  urlAPI: string;

  constructor(private http: HttpClient) { 
    this.urlAPI = AppConstants.ROOT_URI + '/Authentication';
  }

  login(username:string, password:string): Observable<any> {
    this.authInfo = new Certification(username, password);
    var body = util.inspect(this.authInfo);
    return Helper.InvokeAPI(this.urlAPI, 'post', body, this.http);
  }

  logout(): void {
    this.authInfo.status = AuthStatus.Logout; 
    this.authInfo.token = '';
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
        this.authInfo = JSON.parse(authData);
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
}
