using AutoMapper;
using EFS.APIModel.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    public class WorkflowController : BaseController
    {
        public IEnumerable<WorkflowItem> Get()
        {
            var wfs = new List<WorkflowItem>();
            wfs.Add(new WorkflowItem() { ID = Guid.NewGuid(), Name = "asdf" } );
            wfs.Add(new WorkflowItem() { ID = Guid.NewGuid(), Name = "lkjkj" });

            return wfs;
        }
    }
}
