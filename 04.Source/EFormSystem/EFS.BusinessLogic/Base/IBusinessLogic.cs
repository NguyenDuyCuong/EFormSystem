using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.BusinessLogic.Base
{
    public interface IBusinessLogic<T> where T : class
    {
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Add(T item);

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Remove(T item);

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        void Update(T item);

        /// <summary>
        /// Deletes the record by the ID
        /// </summary>
        /// <param name="id">
        /// The unique ID
        /// </param>
        void Delete(Guid id);
    }
}
