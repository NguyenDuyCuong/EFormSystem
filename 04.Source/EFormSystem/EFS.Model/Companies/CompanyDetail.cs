using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Companies
{
    public class CompanyDetail : EntityBase, IAggregateRoot
    {
        public Guid Id { get; set; }

        public string Location { get; set; }

        public decimal? BaseSocialInsuranceSalary { get; set; }

        public decimal? InsuranceSalaryRate { get; set; }

        public override DateTime CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Guid? UpdatedBy { get; set; }

    }

}
