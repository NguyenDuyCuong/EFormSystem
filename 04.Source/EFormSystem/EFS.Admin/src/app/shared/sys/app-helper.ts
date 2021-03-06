import * as CryptoJS from 'crypto-js';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { AppConstants } from './app-constants';

export class Helper{
    static Encrypt(message:string, key:string) {
        //var keyHex = CryptoJS.enc.Utf8.parse(key);
        //var encrypted = CryptoJS.DES.encrypt(message, key, {mode: CryptoJS.mode.ECB,padding: CryptoJS.pad.Pkcs7});                
        var encrypted = CryptoJS.enc.Base64.stringify(message, key);
        
        return encrypted;
    }

    static Decrypt(ciphertext: string, key: string) {
        //var keyHex = CryptoJS.enc.Utf8.parse(key);        
        //var decrypted = CryptoJS.DES.decrypt({ciphertext: CryptoJS.enc.Base64.parse(ciphertext)}, keyHex, {mode: CryptoJS.mode.ECB,padding: CryptoJS.pad.Pkcs7});
        var decrypted = CryptoJS.AES.decrypt(ciphertext, "Secret Passphrase");

        return decrypted.toString(CryptoJS.enc.Utf8);
    }

    static InvokeAPI(url: string, method: any, body: any, http: HttpClient, authToken = '', ...args){
        var header = new HttpHeaders().set('Authorization', authToken).set('Content-Type', 'application/json').set('data-type', 'application/json; charset=utf-8');

        var params = new HttpParams();
        args.forEach(arg => {
            if (arg.key)
                params.set(arg.key, arg.value);
        });
       
        return http[method](url, body, {
            headers: header,
            params: params,
        });
    }

    static InvokeAPIFull(url: string, method: any, body: any, http: HttpClient, authToken = '', ...args){        
        var header = new HttpHeaders().set('Authorization', authToken).set('Content-Type', 'application/json').set('data-type', 'application/json; charset=utf-8');
        
        var params = new HttpParams();
        args.forEach(arg => {
            if (arg.key)
                params.set(arg.key, arg.value);
        });
       
        return http[method](url, body, {
            headers:  header,
            params: params,
            observe: 'response',
        });
    }
}