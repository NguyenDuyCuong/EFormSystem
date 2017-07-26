﻿using EFS.Common.Encryption;
using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFS.Model.Users
{
    /// <summary>
    /// A user with the admin system.
    /// </summary>
    public sealed class User : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public EncryptedString EncryptedPassword { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Username))
            {
                ValidationErrors.Add("Username");
            }

            if (Password == null || !EncryptedPassword.EncryptedValue.Any())
            {
                ValidationErrors.Add("Password");
            }
        }
    }
}
