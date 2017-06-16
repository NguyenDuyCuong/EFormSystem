using EFS.APIModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.APIModel.Workflows
{
    public class WorkflowItem : ModelItem
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
