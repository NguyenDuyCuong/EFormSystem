import {Helper} from '../shared/sys/app-helper';

export class Certification {
    username: string;
    password: string;
    token: string;
    ip: string;
    ticks: number;
    useragent: string;

    constructor( data: any ){ 
        this.username = data.username;
        this.password = data.password;
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
