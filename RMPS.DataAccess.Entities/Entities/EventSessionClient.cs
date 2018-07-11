using System;

namespace RMPS.DataAccess.Entities
{
    public partial class EventSessionClient
    {
        public Guid ClientsId { get; set; }
        public Guid EventSessionsId { get; set; }

        public Client Clients { get; set; }
        public EventSession EventSessions { get; set; }
    }
}
