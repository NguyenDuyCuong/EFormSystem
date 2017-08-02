using EFS.APIModel.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFS.APIModel.Authentication
{
    /// <summary>
    /// The post authentication.
    /// </summary>
    public class AuthenticationItem : ModelItem
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Token { get; set; }

        public DateTime LoginDate { get; set; }

        public int Status { get; set; }

        public bool IsRemember { get; set; }
    }
}
