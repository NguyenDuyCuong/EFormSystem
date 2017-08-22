import {Helper} from '../shared/sys/app-helper';   
import { AppConstants } from '../shared/sys/app-constants';

export class Certification {
    username: string;
    key: string;
    token: string;
    ip: string;
    ticks: number;
    useragent: string;

    constructor( data: any ){ 
        if (data.username)
            this.username = data.username;        
        if(data.key)
            this.key = data.key;
        if (data.token)
            this.token = data.token;
        if (data.ip)
            this.ip = data.ip;
        if (data.ticks)
            this.ticks = data.ticks;        
        if (data.useragent)
            this.useragent = data.useragent;
    };
}
