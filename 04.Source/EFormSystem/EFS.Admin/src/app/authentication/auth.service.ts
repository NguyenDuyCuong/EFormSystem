import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/delay';
import * as CryptoJS from 'crypto-js';

import * as util from 'util';
import { Helper } from '../shared/sys/app-helper';

import { AuthStatus } from '../shared/sys/app-enums';
import { AppConstants } from '../shared/sys/app-constants';

import { Certification } from './certification.class';

@Injectable()
export class AuthService {
  authInfo: Certification;
  clientIp: string;
  
  // store the URL so we can redirect after logging in
  redirectUrl: string;
  urlsAPI = {
    login: '',
    register: '',
    ip: ''
  };

  constructor(private http: HttpClient) { 
    this.DeclareUrlAPI();
    this.getIp();
  }

  private DeclareUrlAPI = function () {
    this.urlsAPI.login = AppConstants.ROOT_URI + '/Authentication/Login';
    this.urlsAPI.register = AppConstants.ROOT_URI + '/Authentication/Register';
    this.urlsAPI.ip = AppConstants.ROOT_URI + '/Authentication/GetIp';
  }

  generate = function (username, password) {
    if (username && password) {
        // If the user is providing credentials, then create a new key.
        this.logout();
    }
    
    this.authInfo = new Certification({});
    // Set the username.
    this.authInfo.username = this.authInfo.username || username;
    // Set the key to a hash of the user's password + salt.
    this.authInfo.key = this.authInfo.key || CryptoJS.enc.Base64.stringify(CryptoJS.HmacSHA256([password, AppConstants.Secret_Salt].join(':'), AppConstants.Secret_Salt));
    // Set the client IP address.
    this.authInfo.ip = this.authInfo.ip || this.clientIp;
   
    // Get the (C# compatible) ticks to use as a timestamp. http://stackoverflow.com/a/7968483/2596404
    var ticks = ((new Date().getTime() * 10000) + 621355968000000000);
    // Construct the hash body by concatenating the username, ip, and userAgent.
    var message = [this.authInfo.username, this.authInfo.ip, navigator.userAgent.replace(/ \.NET.+;/, ''), ticks].join(':');
    // Hash the body, using the key.
    var hash = CryptoJS.HmacSHA256(message, this.authInfo.key);
    // Base64-encode the hash to get the resulting token.
    var token = CryptoJS.enc.Base64.stringify(hash);
    // Include the username and timestamp on the end of the token, so the server can validate.
    var tokenId = [this.authInfo.username, ticks].join(':');
    // Base64-encode the final resulting token.
    var tokenStr = CryptoJS.enc.Utf8.parse([token, tokenId].join(':'));
    this.authInfo.token = CryptoJS.enc.Base64.stringify(tokenStr);
    return this.authInfo.token;
  }

  private getIp = function () {
    Helper.InvokeAPI(this.urlsAPI.ip, 'get', '', this.http)
    .subscribe(resp => {
      this.clientIp = resp[0];
    },
    error => {
      console.log(error.message);
    });
}

  login(username:string, password:string, successCallback, failCallback): void {
    this.generate(username, password);

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
    this.authInfo = new Certification({}); 
    localStorage.removeItem('AuthInfo');
  }

  get IsLogin() {
    return this.authInfo != null && this.authInfo.token === '';
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

    if (this.authInfo == null || this.authInfo.token === '')
      return false;

    return false;
  }

  register(username:string, password:string, successCallback, failCallback): void {
    this.generate(username, password);

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
    Helper.InvokeAPIFull(AppConstants.ROOT_URI + '/Users/Test', 'post', body, this.http, this.authInfo.token)
      .subscribe(resp => {
        if (resp.body){
          alert('');
        }
      },
      error => {
        
      });
  }
}
