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

namespace EO.WFS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Demo")]
    public class DemoController : BaseController<IDemoBL>
    {
        public DemoController(IOptions<AppConfigures> optionsAccessor) : base(optionsAccessor)
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