export class FormsAuthentication {
    SetAuthenticationToken(token: string): void {
        //FormsAuthentication.SetAuthCookie(token, false);
    }

    GetAuthenticationToken(): string{
        return 'HttpContext.Current.User.Identity.Name';
    }

    SignOut(): void{
        //FormsAuthentication.SignOut();
    }
}
