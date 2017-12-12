using EO.DataAccess.Base;
using EO.Models.Demo;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Demo
{
    public class DemoRepository : RepositoryBase, IRepository
    {
        public DemoRepository(string stringConnection) : base(stringConnection)
        {
        }
    }
}
