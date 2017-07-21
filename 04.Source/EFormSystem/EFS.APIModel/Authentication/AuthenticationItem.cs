﻿using EFS.APIModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.APIModel.Authentication
{
    /// <summary>
    /// The post authentication.
    /// </summary>
    public class AuthenticationItem : ModelItem
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string EncryptedPass { get; set; }

        public string Token { get; set; }

        public DateTime LoginDate { get; set; }

        public int Status { get; set; }
    }
}
