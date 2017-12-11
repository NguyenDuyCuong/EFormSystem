using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Base
{
    public interface ISpecification<T>
    {
        String GetSqlQuery();
    }
}
