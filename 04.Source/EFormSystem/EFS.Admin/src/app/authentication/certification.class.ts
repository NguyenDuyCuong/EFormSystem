import {Helper} from '../shared/sys/app-helper';

export class Certification {
    username: string;
    encryptedPass: string;
    token: string;
    loginDate: Date;
    status = 0;
    private createdDate = 0;

    constructor( data: any ){ 
        this.username = data.username;
        this.encryptedPass = Helper.Encrypt(data.encryptedPass, data.username);
        if (data.token)
            this.token = data.token;
        if (data.loginDate){
            this.loginDate = new Date(data.loginDate);
        }
        if (data.status)
            this.status = data.status;        

        this.createdDate = Date.now();
    };
}
