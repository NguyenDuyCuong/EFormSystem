using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.DataAccess.Base
{
    /// <summary>
    /// The ReadOnlyRepository interface.
    /// </summary>
    /// <typeparam name="T">
    /// The aggregate root entity.
    /// </typeparam>
    public interface IReadOnlyRepository<T> where T : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The find by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T FindById(Guid id);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/> of T.
        /// </returns>
        IEnumerable<T> GetAll();
    }
}
