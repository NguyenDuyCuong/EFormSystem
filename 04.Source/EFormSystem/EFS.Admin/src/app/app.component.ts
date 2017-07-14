import { Component, OnInit } from '@angular/core';
import { BaseComponent } from "./base.component";

import { AuthService } from "./services/auth.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent extends BaseComponent implements OnInit {
  title = 'app';

  constructor(protected authService: AuthService) {
    super();
  }

  ngOnInit() {
    this.chekCredentials();
  }
}
