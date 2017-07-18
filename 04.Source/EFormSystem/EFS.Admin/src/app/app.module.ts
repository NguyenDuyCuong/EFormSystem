import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { Router } from '@angular/router';

import { AppComponent }            from './app.component';
import { AppRoutingModule }        from './app-routing.module';

import { LoginRoutingModule }      from './authentication/login/login-routing.module';
import { LoginComponent }          from './authentication/login/login.component';
import { PageNotFoundComponent }   from './not-found.component';


@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    LoginRoutingModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  declarations: [
    AppComponent,
    LoginComponent,
    PageNotFoundComponent
  ],
  providers: [
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {
  // Diagnostic only: inspect router configuration
  constructor(router: Router) {
    console.log('Routes: ', JSON.stringify(router.config, undefined, 2));
  }
}