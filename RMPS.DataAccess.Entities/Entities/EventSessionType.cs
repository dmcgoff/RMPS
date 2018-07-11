using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class EventSessionType
    {
        public EventSessionType()
        {
            EventSessions = new HashSet<EventSession>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<EventSession> EventSessions { get; set; }
    }
}
