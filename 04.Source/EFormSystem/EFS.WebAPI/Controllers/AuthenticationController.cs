﻿using EFS.APIModel.Authentication;
using EFS.BusinessLogic.Users;
using EFS.Common.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    public class AuthenticationController : BaseController
    {
        /// <summary>
        /// The _encryption service.
        /// </summary>
        private readonly IEncryptionService _encryptionService;

        /// <summary>
        /// The _user BL.
        /// </summary>
        private readonly IUserBL _userBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        /// <param name="userDataMapper">
        /// The user Data Mapper.
        /// </param>
        /// <param name="encryptionService">
        /// The encryption service.
        /// </param>
        public AuthenticationController(
            IUserBL userBL,
            IEncryptionService encryptionService)
        {
            _userBL = userBL;
            _encryptionService = encryptionService;
        }

        /// <summary>
        /// The post method.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="HttpResponseMessage"/>.
        /// </returns>
        //public RequestResult Post(PostAuthentication item)
        //{

        //    var user = _userDataMapper.FindByUsername(item.Username);

        //    if (user != null)
        //    {
        //        if (user.Password.EncryptedValue.SequenceEqual(_encryptionService.Encrypt(item.Password)))
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, TokenAuthentication.Token);
        //        }
        //    }

        //    return BadRequest();
        //}
    }
}
