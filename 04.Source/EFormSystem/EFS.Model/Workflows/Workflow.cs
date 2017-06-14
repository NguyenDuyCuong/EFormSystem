using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.Model.Workflows
{
    public class Workflow : Base.EntityBase, Base.IAggregateRoot
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
