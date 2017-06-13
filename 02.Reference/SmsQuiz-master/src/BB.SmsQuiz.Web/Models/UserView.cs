// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserView.cs" company="contentedcoder.com">
//   contentedcoder.com
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;


namespace BB.SmsQuiz.Web.Models
{
    /// <summary>
    /// The user view.
    /// </summary>
    public class UserView
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}