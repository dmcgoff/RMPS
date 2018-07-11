using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ChatroomUser
    {
        public ChatroomUser()
        {
            ChatroomUserConnections = new HashSet<ChatroomUserConnection>();
            ChatroomUserMessages = new HashSet<ChatroomUserMessage>();
        }

        public Guid Id { get; set; }
        public Guid ChatroomId { get; set; }
        public Guid UserId { get; set; }
        public bool IsModerator { get; set; }
        public bool IsMuted { get; set; }
        public bool IsFocused { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public Chatroom Chatroom { get; set; }
        public User User { get; set; }
        public ICollection<ChatroomUserConnection> ChatroomUserConnections { get; set; }
        public ICollection<ChatroomUserMessage> ChatroomUserMessages { get; set; }
    }
}
