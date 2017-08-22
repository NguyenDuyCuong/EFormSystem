using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Base
{
    /// <summary>
    /// The aggregate root for use in the repository.
    /// </summary>
    /// <remarks>
    /// This indicates what objects can be directly loaded from the repository.
    /// </remarks>
    public interface IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        Guid Id { get; set; }
    }
}
