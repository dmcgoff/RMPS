using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Chatroom
    {
        public Chatroom()
        {
            ChatroomUsers = new HashSet<ChatroomUser>();
            Webinars = new HashSet<Webinar>();
        }

        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsMuted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<ChatroomUser> ChatroomUsers { get; set; }
        public ICollection<Webinar> Webinars { get; set; }
    }
}
