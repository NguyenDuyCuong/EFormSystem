using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Companies
{
    public class Company : EntityBase, IAggregateRoot
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Fax { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public Guid UserId { get; set; }

        public int Status { get; set; }

        public Guid? ParentId { get; set; }

        public string Type { get; set; }

        public DateTime? ActivatedDate { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public override DateTime CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }
    }

}
