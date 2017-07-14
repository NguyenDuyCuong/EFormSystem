import { Injectable } from '@angular/core';

@Injectable()
export class AuthService {
  SetAuthenticationToken(token: string) : void {
    
  };
  
  GetAuthenticationToken(): string {
    return 'cuongnd_token';
  };
        
  SignOut(): void{

  };
}
