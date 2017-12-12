using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EO.Models;
using EO.Business.Demo;
using EO.Shared.Global;
using Microsoft.Extensions.Options;
using EO.Business.Base;
using EO.Models.Base;
using Microsoft.Extensions.Logging;

namespace EO.WFS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Demo")]
    public class DemoController : BaseController<IDemoBL>
    {
        public DemoController(IOptions<AppConfigures> optionsAccessor
                                , ILogger<IBusinessLogic> logger) : base(optionsAccessor, logger)
        {
        }

        protected override IBusinessLogic GetBusinessLayer(AppConfigures options)
        {
            return new DemoBL(options);
        }

        [HttpGet]
        public string[] Get()
        {
            return BusinessLayer.Values();
        }
    }
}