import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';

import { AuthStatus } from '../sys/app-enums'

import { Certification } from './certification.class';

@Injectable()
export class AuthService {
  authInfo: Certification;
  
  // store the URL so we can redirect after logging in
  redirectUrl: string;

  constructor(private http: HttpClient) {
    this.authInfo = new Certification();
  }

  login(): Observable<any> {
    let body = {"username": "cuongnd","password": "12345"};
    return this.http.post<any>('http://localhost:50266/api/Authentication', JSON.stringify(body), {
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

  Vertify(): boolean {
    if (this.authInfo == null || this.authInfo.status !== AuthStatus.Login)
      return false;

    if(this.authInfo.token === '')
      return false;

    return true;
  }
}
