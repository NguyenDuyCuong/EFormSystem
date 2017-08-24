import { Component } from '@angular/core';
import {MdDialogRef} from '@angular/material';

@Component({
    selector: 'spinner-dialog',
    templateUrl: './spinner-dialog.component.html',
  })
export class SpinnerDialogComponent {
  constructor(public dialogRef: MdDialogRef<SpinnerDialogComponent>) {}
}