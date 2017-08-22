using Dapper.Contrib.Extensions;
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
    [Table("[User]")]
    public sealed class User : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; }
        
        public byte[] Password { get; set; }
        public override DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
