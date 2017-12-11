using Dapper;
using EO.DataAccess.Base;
using EO.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EO.DataAccess.Workflows
{
    public class WorkflowRepository : RepositoryBase<Workflow>, IRepository<Workflow>
    {
        public WorkflowRepository(string stringConnection) : base(stringConnection)
        {
        }
    }
}
