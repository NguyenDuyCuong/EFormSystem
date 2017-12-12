using EO.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Base
{
    public interface IRepository
    {
        void Add(IEntity item);
        void Update(IEntity item);
        void Remove(IEntity item);
        void Remove(ISpecification specification);
        List<T> Query<T>(ISpecification specification);
    }
}
