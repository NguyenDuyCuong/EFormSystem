using Dapper.Contrib.Extensions;
using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Users
{
    [Table("AppUser")]
    public class AppUser : EntityBase, IAggregateRoot
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string UserName { get; set; }

        public DateTime? LastLogin { get; set; }

        public int Status { get; set; }

        public string Token { get; set; }

        public override DateTime CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

    }
}
