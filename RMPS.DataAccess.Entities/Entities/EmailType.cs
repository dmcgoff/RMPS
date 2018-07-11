using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class EmailType
    {
        public EmailType()
        {
            LogsEmailHistories = new HashSet<LogsEmailHistory>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<LogsEmailHistory> LogsEmailHistories { get; set; }
    }
}
