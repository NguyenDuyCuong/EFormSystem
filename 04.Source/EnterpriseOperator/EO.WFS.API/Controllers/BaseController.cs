using EO.Business.Base;
using EO.Models.Base;
using EO.Shared.Global;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EO.WFS.API.Controllers
{
    public abstract class BaseController<T> where T : IBusinessLogic
    {
        public BaseController(IOptions<AppConfigures> optionsAccessor)
        {
            _options = optionsAccessor.Value;
            businessLayer = GetBusinessLayer(_options);
        }

        protected abstract IBusinessLogic GetBusinessLayer(AppConfigures options);

        protected readonly AppConfigures _options;

        private readonly IBusinessLogic businessLayer;
        protected T BusinessLayer => (T)businessLayer;
    }
}
