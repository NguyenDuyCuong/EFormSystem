using EFS.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.DataAccess.Workflows
{    
    /// <summary>
    /// The Workflow Repository interface.
    /// </summary>
    public interface IWorkflowRepository : IRepository<Model.Workflows.Workflow>
    {
       
    }
}
