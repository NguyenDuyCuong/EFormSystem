import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MdDialog, MdDialogRef, MdDialogConfig } from '@angular/material';
import { MdSnackBar } from '@angular/material';


import {FormState} from '../sys/app-enums';
import {SpinnerDialogComponent} from '../components/spinner-dialog.component';

@Injectable()
export class BaseComponent {
    constructor(protected httpClient: HttpClient, protected dialog: MdDialog, protected snackBar: MdSnackBar ) { }

    public IsBusy = false;
    
    protected SetMode (state: FormState) {
        switch (state) {
            case FormState.Waiting : {
                this.IsBusy = true;
                this.ShowWaitingDialog();
                break;
            }
            default:{
                break;
            }
        }
    }

    protected ShowWaitingDialog(){
        var config = new MdDialogConfig();
        config.disableClose = true;
        config.panelClass = "dialog-no-border";

        let dialogRef = this.dialog.open(SpinnerDialogComponent, config);
        dialogRef.afterClosed().subscribe(result => {
          this.IsBusy = false;
        });
    }

    protected SetMessage(message: string, action = ''){
        this.snackBar.open(message, action, {
            duration: 2000,
        });
    }
}