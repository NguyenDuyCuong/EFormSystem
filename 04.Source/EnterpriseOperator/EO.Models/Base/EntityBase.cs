using System;
using System.Collections.Generic;
using System.Text;

namespace EO.Models.Base
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
