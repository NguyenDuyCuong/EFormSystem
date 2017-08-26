using AutoMapper;
using EFS.APIModel.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using EFS.Common.Global;
using EFS.Common.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Localization;

namespace EFS.WebAPI.Controllers
{
    public class WorkflowController : BaseController
    {
        public WorkflowController(IOptions<AppConfigures> optionsAccessor
            , ITokenAuthorizationService authenService
            , ILoggerFactory loggerFactory) : base(optionsAccessor, authenService, loggerFactory)
        {
        }

        public IEnumerable<WorkflowItem> Get()
        {
            var wfs = new List<WorkflowItem>();
            wfs.Add(new WorkflowItem() { ID = Guid.NewGuid(), Name = "asdf" } );
            wfs.Add(new WorkflowItem() { ID = Guid.NewGuid(), Name = "lkjkj" });

            return wfs;
        }
    }
}
