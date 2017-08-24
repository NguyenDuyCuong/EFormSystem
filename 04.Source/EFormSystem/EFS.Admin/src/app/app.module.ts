import { NgModule }       from '@angular/core';
import { FormsModule }    from '@angular/forms';
import {MdaModule} from './mda.module';
import { HttpClientModule, HttpClientXsrfModule }        from '@angular/common/http';

import { Router } from '@angular/router';

import { AppComponent }            from './app.component';
import { AppRoutingModule }        from './app-routing.module';

import { LoginRoutingModule }      from './authentication/login/login-routing.module';
import { LoginComponent }          from './authentication/login/login.component';
import { PageNotFoundComponent }   from './not-found.component';
import {SpinnerDialogComponent} from './shared/components/spinner-dialog.component';

import { DashboardModule } from './dashboard/dashboard.module'



@NgModule({
  imports: [
    HttpClientModule,
    HttpClientXsrfModule.withOptions({
      cookieName: 'My-Xsrf-Cookie',
      headerName: 'My-Xsrf-Header',
    }),
    MdaModule,
    FormsModule,
    DashboardModule,
    LoginRoutingModule,
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    LoginComponent,
    PageNotFoundComponent,
    SpinnerDialogComponent
  ],
  entryComponents: [
    SpinnerDialogComponent
  ],
  providers: [
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {}