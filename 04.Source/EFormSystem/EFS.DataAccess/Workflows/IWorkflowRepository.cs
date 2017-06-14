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
        /// <summary>
        /// The find by workflowname.
        /// </summary>
        /// <param name="workflowname">
        /// The workflowname.
        /// </param>
        /// <returns>
        /// The <see cref="Model.Workflows.Workflow"/>.
        /// </returns>
        Model.Workflows.Workflow FindByWorkflowName(string workflowname);
    }
}
