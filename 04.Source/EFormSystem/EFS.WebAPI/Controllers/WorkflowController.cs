using AutoMapper;
using EFS.APIModel;
using EFS.Model.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFS.WebAPI.Controllers
{
    public class WorkflowController : BaseController
    {
        /// <summary>
        /// The _mapper.
        /// </summary>
        private readonly IMapper _mapper;

        public WorkflowController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<WorkflowItem> Get()
        {
            var wfs = new List<Workflow>();
            wfs.Add(new Workflow() { ID = Guid.NewGuid(), Name = "asdf" } );
            wfs.Add(new Workflow() { ID = Guid.NewGuid(), Name = "lkjkj" });

            return _mapper.Map<IEnumerable<Workflow>, IEnumerable<WorkflowItem>>(wfs);
        }
    }
}
