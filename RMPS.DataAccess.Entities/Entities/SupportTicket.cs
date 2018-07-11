using System;

namespace RMPS.DataAccess.Entities
{
    public partial class SupportTicket
    {
        public Guid? SupportSourceId { get; set; }
        public string Issue { get; set; }
        public string Solution { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string RequestedByUserText { get; set; }
        public int? TimeSpent { get; set; }
        public Guid? AssignedToUserId { get; set; }
        public Guid? RequestedByUserId { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? ClientId { get; set; }
        public Guid SupportCategoryId { get; set; }
        public Guid Id { get; set; }
        public Guid? UserRoleId { get; set; }

        public User AssignedToUser { get; set; }
        public Client Client { get; set; }
        public User RequestedByUser { get; set; }
        public SupportCategory SupportCategory { get; set; }
        public SupportSource SupportSource { get; set; }
        public UserRole UserRole { get; set; }
    }
}
