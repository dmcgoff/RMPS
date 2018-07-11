using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ToolCategory
    {
        public ToolCategory()
        {
            Tools = new HashSet<Tool>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<Tool> Tools { get; set; }
    }
}
