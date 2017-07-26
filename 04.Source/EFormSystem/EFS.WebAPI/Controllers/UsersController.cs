using EFS.APIModel.Users;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using EFS.Model.Users;
using EFS.WebAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    /// <summary>
    /// The users controller.
    /// </summary>
    [TokenValidationAttribute]
    public class UsersController : BaseController
    {
        /// <summary>
        /// The _encryption service.
        /// </summary>
        private readonly IEncryptionService _encryptionService;
        private readonly IUserBL _userBL;

        public UsersController(
            IUserBL userBL,
            IEncryptionService encryptionService)
        {
            _userBL = userBL;
            _encryptionService = encryptionService;
        }
    }
}
