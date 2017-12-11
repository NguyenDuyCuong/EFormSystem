using EO.DataAccess.Base;
using EO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Workflows
{
    public class WorkflowByIdSpecification : ISpecification<Workflow>
    {
        private Guid id;
        private readonly string tableName = "Workflow";

        public WorkflowByIdSpecification(Guid Id)
        {
            this.id = Id;
        }

        public string GetSqlQuery()
        {
            return String.Format("SELECT * FROM %1$s WHERE `%2$s` = %3$d';",
                tableName,
                "ID",
                id
        );
        }
    }
}
