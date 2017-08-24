export enum AuthStatus{
    UnAuth = 1,
    Login = 2,
    Logout = 4,
    Fail = 8,
}

export enum FormState{
    Create = 1,
    View = 2,
    Update = 4,
    Delete = 8,
    Waiting = 16,
}