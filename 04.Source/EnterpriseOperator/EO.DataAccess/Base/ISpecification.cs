using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Base
{
    public interface ISpecification
    {
        String GetSqlQuery();
    }
}
