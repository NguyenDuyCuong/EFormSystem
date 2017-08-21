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
    Helper.InvokeAPIFull(AppConstants.ROOT_URI + '/Users/Test', 'post', body, this.http, this.authInfo.token)
      .subscribe(resp => {
        if (resp.body){
          alert('');
        }
      },
      error => {
        
      });
  }

  SecurityManager () {
    salt: 'rz8LuOtFBXphj9WQfvFh', // Generated at https://www.random.org/strings
    username: localStorage['SecurityManager.username'],
    key: localStorage['SecurityManager.key'],
    ip: null,
    generate: function (username, password) {
        if (username && password) {
            // If the user is providing credentials, then create a new key.
            SecurityManager.logout();
        }
        // Set the username.
        SecurityManager.username = SecurityManager.username || username;
        // Set the key to a hash of the user's password + salt.
        SecurityManager.key = SecurityManager.key || CryptoJS.enc.Base64.stringify(CryptoJS.HmacSHA256([password, SecurityManager.salt].join(':'), SecurityManager.salt));
        // Set the client IP address.
        SecurityManager.ip = SecurityManager.ip || SecurityManager.getIp();
        // Persist key pieces.
        if (SecurityManager.username) {
            localStorage['SecurityManager.username'] = SecurityManager.username;
            localStorage['SecurityManager.key'] = SecurityManager.key;
        }
        // Get the (C# compatible) ticks to use as a timestamp. http://stackoverflow.com/a/7968483/2596404
        var ticks = ((new Date().getTime() * 10000) + 621355968000000000);
        // Construct the hash body by concatenating the username, ip, and userAgent.
        var message = [SecurityManager.username, SecurityManager.ip, navigator.userAgent.replace(/ \.NET.+;/, ''), ticks].join(':');
        // Hash the body, using the key.
        var hash = CryptoJS.HmacSHA256(message, SecurityManager.key);
        // Base64-encode the hash to get the resulting token.
        var token = CryptoJS.enc.Base64.stringify(hash);
        // Include the username and timestamp on the end of the token, so the server can validate.
        var tokenId = [SecurityManager.username, ticks].join(':');
        // Base64-encode the final resulting token.
        var tokenStr = CryptoJS.enc.Utf8.parse([token, tokenId].join(':'));
        return CryptoJS.enc.Base64.stringify(tokenStr);
    },
    logout: function () {
        SecurityManager.ip = null;
        localStorage.removeItem('SecurityManager.username');
        SecurityManager.username = null;
        localStorage.removeItem('SecurityManager.key');
        SecurityManager.key = null;
    },
    getIp: function () {
        var result = '';
        $.ajax({
            url: '/ip',
            method: 'GET',
            async: false,
            success: function (ip) {
                result = ip;
            }
        });
        return result;
    }
}
}
