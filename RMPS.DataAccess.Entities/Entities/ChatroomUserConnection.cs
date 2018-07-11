using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ChatroomUserConnection
    {
        public Guid Id { get; set; }
        public Guid ChatroomUserId { get; set; }
        public string ConnectionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ChatroomUser ChatroomUser { get; set; }
    }
}
