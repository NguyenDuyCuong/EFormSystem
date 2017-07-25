import {Helper} from '../shared/sys/app-helper';

export class Certification {
    username: string;
    encryptedPass: string;
    token: string;
    loginDate: Date;
    status = 0;
    private createdDate = 0;

    constructor( username: string, password:string ){ 
        this.username = username;
        this.encryptedPass = Helper.Encrypt(password, username);
        this.createdDate = Date.now();
    };
}
