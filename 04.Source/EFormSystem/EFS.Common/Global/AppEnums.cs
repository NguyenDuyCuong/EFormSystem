using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Common.Global
{
    public enum ValidationErrorType
    {
        UnHandleError = 1,
        LogicError = 2,
        DatabaseError = 4,
        FrameworkError = 8,        
    }

    public enum AuthStatus
    {
        UnAuth = 1,
        Login = 2,
        Logout = 4,
        Fail = 8,
    }
}
