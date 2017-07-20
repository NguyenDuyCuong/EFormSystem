import { AuthStatus } from '../sys/app-enums';

export class Certification {
    username: string;
    password: string;
    token: string;
    loginDate: Date;
    status = 0;
    private createdDate = 0;

    constructor( ){ 
        this.createdDate = Date.now();
    };

    get IsLogin() {
        return this.status == AuthStatus.Login;
    }
}
