using System;
using System.Collections.Generic;
using System.Text;

namespace EO.DataAccess.Base
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        void Remove(ISpecification<T> specification);
        List<T> Query(ISpecification<T> specification);
    }
}
