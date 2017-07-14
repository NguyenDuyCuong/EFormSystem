import { Component, OnInit } from '@angular/core';

import {FormsAuthentication} from './services/forms-authentication.class';
import { AuthService } from "./services/auth.service";

export class BaseComponent {
  formAuthentication : FormsAuthentication;
  protected authService: AuthService;
  
  chekCredentials(): void{
    if (this.formAuthentication)
      alert(this.authService.GetAuthenticationToken());
    else
      '';
  }
}
