using Dapper;
using EFS.APIModel.Base;
using EFS.Common.Global;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFS.BusinessLogic.Base
{
    /// <summary>
    /// The Base Business Logic.
    /// </summary>
    /// <typeparam name="T">
    /// The data entity.
    /// </typeparam>
    public class BaseBusinessLogic<T> where T : ModelItem
    {
        protected AppConfigures _options;

        public BaseBusinessLogic(AppConfigures configs)
        {
            _options = configs;
            RegisterMapper();
        }

        protected virtual void RegisterMapper() { }
    }
}
