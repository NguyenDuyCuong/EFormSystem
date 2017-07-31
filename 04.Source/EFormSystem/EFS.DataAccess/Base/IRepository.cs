using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.DataAccess.Base
{
    /// <summary>
    /// The repository interface.
    /// </summary>
    /// <typeparam name="T">
    /// The domain entity
    /// </typeparam>
    public interface IRepository<T> : IReadOnlyRepository<T> where T : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// Inserts the specified item.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        T Insert(T item);

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
