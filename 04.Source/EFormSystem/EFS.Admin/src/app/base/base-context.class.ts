import { FormsAuthentication } from "../services/forms-authentication.class";

export class BaseContext {
    constructor(private readonly _formsAuthentication: FormsAuthentication){}
    
    GetFormsCredentials(): FormsAuthentication{ 
        return this._formsAuthentication;
    };

    // Client(): Promise<any> {
    //         if ( this._formsAuthentication.GetAuthenticationToken() !== '')
    //         {
    //             _client.DefaultRequestHeaders.Authorization 
    //                 = new AuthenticationHeaderValue(FormsAuthentication.GetAuthenticationToken());
    //         }

    //         return _client;
        
    // };
}
