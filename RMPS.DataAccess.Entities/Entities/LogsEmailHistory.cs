using System;

namespace RMPS.DataAccess.Entities
{
    public partial class LogsEmailHistory
    {
        public Guid Id { get; set; }
        public Guid EmailTypeId { get; set; }
        public Guid? LogsNightlyJobId { get; set; }
        public string RecipientEmailAddress { get; set; }
        public Guid? RecipientUserId { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? ClientId { get; set; }

        public Client Client { get; set; }
        public EmailType EmailType { get; set; }
        public LogsNightlyJob LogsNightlyJob { get; set; }
        public User RecipientUser { get; set; }
    }
}
