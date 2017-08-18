import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule, HttpClientXsrfModule }        from '@angular/common/http';

import { Router } from '@angular/router';

import { AppComponent }            from './app.component';
import { AppRoutingModule }        from './app-routing.module';

import { LoginRoutingModule }      from './authentication/login/login-routing.module';
import { LoginComponent }          from './authentication/login/login.component';
import { PageNotFoundComponent }   from './not-found.component';

import { DashboardModule } from './dashboard/dashboard.module'

import {MdButtonModule, MdCheckboxModule, MdInputModule} from '@angular/material';

@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    HttpClientXsrfModule.withOptions({
      cookieName: 'My-Xsrf-Cookie',
      headerName: 'My-Xsrf-Header',
    }),
    FormsModule,
    DashboardModule,
    LoginRoutingModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MdButtonModule, MdCheckboxModule, MdInputModule
  ],
  declarations: [
    AppComponent,
    LoginComponent,
    PageNotFoundComponent,
  ],
  providers: [
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {}