using EO.DataAccess.Base;
using EO.Models.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Demo
{
    public class DemoModelByIdSpecification : ISpecification
    {
        private Guid id;
        private readonly string tableName = "Demo";

        public DemoModelByIdSpecification(Guid Id)
        {
            this.id = Id;
        }

        public string GetSqlQuery()
        {
            return String.Format("SELECT 'CuongND'",
                tableName,
                "ID",
                id
        );
        }
    }
}
