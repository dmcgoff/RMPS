﻿using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class SupportSource
    {
        public SupportSource()
        {
            SupportTickets = new HashSet<SupportTicket>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<SupportTicket> SupportTickets { get; set; }
    }
}
