using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Webinar
    {
        public Webinar()
        {
            EventSessions = new HashSet<EventSession>();
        }

        public Guid Id { get; set; }
        public Guid? RecordedMediaObjectId { get; set; }
        public Guid ChatroomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public string Hlspath { get; set; }
        public string Hmackey { get; set; }
        public string LiveStreamId { get; set; }

        public Chatroom Chatroom { get; set; }
        public MediaObject RecordedMediaObject { get; set; }
        public ICollection<EventSession> EventSessions { get; set; }
    }
}
