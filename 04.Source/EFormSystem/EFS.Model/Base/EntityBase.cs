using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Base
{
    /// <summary>
    /// The base class for domain entities.
    /// </summary>
    public abstract class EntityBase 
    {
        public abstract DateTime CreatedDate { get; set; }
    }
}
