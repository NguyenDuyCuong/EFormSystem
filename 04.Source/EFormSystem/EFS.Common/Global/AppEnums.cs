using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Common.Global
{
    public enum ValidationErrorTypes
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

    public enum Layers
    {
        Bussiness = 1,
        DataAccess = 2,
        Service = 4,
        API = 8,
    }

    public enum Levels
    {
        Fatal = 1,
        Hight = 2,
        Normal = 4,
        Low = 8
    }
}
