using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ChatroomUserMessage
    {
        public Guid Id { get; set; }
        public Guid ChatroomUserId { get; set; }
        public string Text { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public bool IsAnonymous { get; set; }

        public ChatroomUser ChatroomUser { get; set; }
    }
}
