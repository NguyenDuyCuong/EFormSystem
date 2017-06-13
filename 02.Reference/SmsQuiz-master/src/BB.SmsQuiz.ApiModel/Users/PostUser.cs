// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PostUser.cs" company="contentedcoder.com">
//   contentedcoder.com
// </copyright>
// <summary>
//   The post user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace BB.SmsQuiz.ApiModel.Users
{
    /// <summary>
    /// The post user.
    /// </summary>
    [Serializable]
    public class PostUser
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