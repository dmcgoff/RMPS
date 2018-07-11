using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class SupportCategory
    {
        public SupportCategory()
        {
            SupportTickets = new HashSet<SupportTicket>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<SupportTicket> SupportTickets { get; set; }
    }
}
