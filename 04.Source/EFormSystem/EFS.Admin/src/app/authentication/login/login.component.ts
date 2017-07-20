import { Component } from '@angular/core';
import { Router, NavigationExtras } from '@angular/router';
import  { AuthService } from '../auth.service';


@Component({
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  username: string;
  password: string;

  constructor(public authService: AuthService, public router: Router) {}

  login() {
    this.authService.login().subscribe(o => {
      // if (this.authService.isLoggedIn) {
      //   // Get the redirect URL from our auth service
      //   // If no redirect has been set, use the default
      //   let redirect = this.authService.redirectUrl ? this.authService.redirectUrl : '/admin';

      //   // Set our navigation extras object
      //   // that passes on our global query params and fragment
      //   let navigationExtras: NavigationExtras = {
      //     queryParamsHandling: 'preserve',
      //     preserveFragment: true
      //   };

      //   // Redirect the user
      //   this.router.navigate([redirect], navigationExtras);
      // }
    });
  }

  logout() {
    this.authService.logout();
  }

}
