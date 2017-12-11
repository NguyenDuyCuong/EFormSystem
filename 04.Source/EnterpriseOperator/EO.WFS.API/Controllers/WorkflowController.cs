using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EO.Models;
using EO.Business.Workflow;

namespace EO.WFS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Workflow")]
    public class WorkflowController : Controller
    {
        private IWorkflowBL bl;

        public WorkflowController(IWorkflowBL workflow)
        {
            bl = workflow;
        }

        [HttpGet]
        public string Get()
        {
            return bl.Get();
        }
    }
}