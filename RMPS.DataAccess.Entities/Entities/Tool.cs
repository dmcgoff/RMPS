using System;

namespace RMPS.DataAccess.Entities
{
    public partial class Tool
    {
        public Guid Id { get; set; }
        public Guid ToolCategoryId { get; set; }
        public Guid FileId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public File File { get; set; }
        public ToolCategory ToolCategory { get; set; }
    }
}
