import * as CryptoJS from 'crypto-js';

export class Helper{
    static Encrypt(message:string, key:string) {
        var keyHex = CryptoJS.enc.Utf8.parse(key);
        var encrypted = CryptoJS.DES.encrypt(message, key, {mode: CryptoJS.mode.ECB,padding: CryptoJS.pad.Pkcs7});        
        
        return encrypted.toString();
    }

    Decrypt(ciphertext: string, key: string) {
        var keyHex = CryptoJS.enc.Utf8.parse(key);        
        var decrypted = CryptoJS.DES.decrypt({ciphertext: CryptoJS.enc.Base64.parse(ciphertext)}, keyHex, {mode: CryptoJS.mode.ECB,padding: CryptoJS.pad.Pkcs7});

        return decrypted.toString(CryptoJS.enc.Utf8);
    }
}