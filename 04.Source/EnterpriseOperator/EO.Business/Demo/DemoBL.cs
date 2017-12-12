using EO.Business.Base;
using System;
using System.Collections.Generic;
using System.Text;
using EO.Shared.Global;
using EO.DataAccess.Base;
using EO.Models.Base;
using EO.DataAccess.Demo;
using EO.Models.Demo;
using System.Linq;

namespace EO.Business.Demo
{
    public class DemoBL : BaseBusinessLogic, IDemoBL
    {
        #region Inherited
        public DemoBL(AppConfigures configs) : base(configs)
        {
        }

        protected override IRepository GetDataAccess()
        {
            return new DemoRepository(_options.ConnectionString);
        }

        protected override void RegisterMapper()
        {

        }
        #endregion

        #region implements
        public string[] Values()
        {
            return _datalayer.Query<string>(new DemoModelByIdSpecification(new Guid())).ToArray();
        } 
        #endregion
    }
}
