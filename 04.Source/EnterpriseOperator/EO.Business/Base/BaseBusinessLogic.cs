using EO.DataAccess.Base;
using EO.Models.Base;
using EO.Shared.Global;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.Business.Base
{
    public abstract class BaseBusinessLogic
    {
        protected AppConfigures _options;
        protected IRepository _datalayer;

        public BaseBusinessLogic(AppConfigures configs)
        {
            _options = configs;
            _datalayer = GetDataAccess();

            RegisterMapper();
        }

        protected abstract IRepository GetDataAccess();

        protected abstract void RegisterMapper();
    }
}
