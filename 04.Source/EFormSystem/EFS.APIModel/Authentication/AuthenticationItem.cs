using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.APIModel.Authentication
{
    /// <summary>
    /// The post authentication.
    /// </summary>
    public class AuthenticationItem
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
