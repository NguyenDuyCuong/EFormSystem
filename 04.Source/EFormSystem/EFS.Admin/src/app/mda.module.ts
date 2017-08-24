import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MdButtonModule, MdCheckboxModule, MdInputModule, MdProgressSpinnerModule
    , MdDialogModule, MdSnackBarModule
} from '@angular/material';

@NgModule({
    imports: [
      BrowserModule,
      BrowserAnimationsModule,
      MdButtonModule, MdCheckboxModule, MdInputModule
    ],
    exports: [
        BrowserModule,
        BrowserAnimationsModule,
        MdButtonModule, MdCheckboxModule, MdInputModule, MdProgressSpinnerModule,
        MdDialogModule, MdSnackBarModule
      ]
  })
  export class MdaModule {}