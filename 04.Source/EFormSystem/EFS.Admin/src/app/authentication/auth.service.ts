import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';

import * as util from 'util';

import { AuthStatus } from '../sys/app-enums';
import { AppConstants } from '../sys/app-constants';

import { Certification } from './certification.class';

@Injectable()
export class AuthService {
  authInfo: Certification;
  
  // store the URL so we can redirect after logging in
  redirectUrl: string;

  constructor(private http: HttpClient) { }

  login(username:string, password:string): Observable<any> {
    this.authInfo = new Certification(username, password);
    var body = util.inspect(this.authInfo);
    return this.http.post<any>(AppConstants.ROOT_URI + '/Authentication', body, {
      headers: new HttpHeaders().set('Content-Type', 'application/json').set('data-type', 'application/json; charset=utf-8'),
    });

    // return this.http.post('/api/authenticate', JSON.stringify({ username: username, password: password }))
    //         .map((response: Response) => {
    //             // login successful if there's a jwt token in the response
    //             let user = response.json();
    //             if (user && user.token) {
    //                 // store user details and jwt token in local storage to keep user logged in between page refreshes
    //                 localStorage.setItem('currentUser', JSON.stringify(user));
    //             }
    //         });
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
