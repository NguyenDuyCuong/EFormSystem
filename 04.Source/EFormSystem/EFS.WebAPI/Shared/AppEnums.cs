using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Shared.AppEnums
{
    public enum AuthStatus
    {
        UnAuth = 1,
        Login = 2,
        Logout = 4,
        Fail = 8,
    }
}
