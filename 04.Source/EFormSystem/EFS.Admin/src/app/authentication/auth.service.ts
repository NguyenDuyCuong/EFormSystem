import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';

@Injectable()
export class AuthService {
  isLoggedIn = false;

  // store the URL so we can redirect after logging in
  redirectUrl: string;

  constructor(private http: HttpClient) {}

  login(): Observable<string> {
    let body = {"username": "cuongnd","password": "12345"};
    return this.http.post<string>('http://localhost:5000/api/Authentication', JSON.stringify(body), {
      headers: new HttpHeaders().set('Content-Type', 'application/json').set('data-type', 'application/json; charset=utf-8'),
    });
  }

  logout(): void {
    this.isLoggedIn = false;
  }
}
