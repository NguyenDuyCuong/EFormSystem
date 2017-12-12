using System;
using System.Collections.Generic;
using System.Text;

namespace EO.Models.Base
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
