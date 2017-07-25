import { Component } from '@angular/core';
import { Router, NavigationExtras } from '@angular/router';
import  { AuthService } from '../auth.service';


@Component({
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  message = '';

  username: string;
  password: string;
  get IsLogin() { 
    return this.authService.IsLogin;
  }

  constructor(public authService: AuthService, public router: Router) {}

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
      if (error.status == '404') {
        this.message = 'Wrong username!';
      }
    });
  }

  logout() {
    this.authService.logout();
  }

}
