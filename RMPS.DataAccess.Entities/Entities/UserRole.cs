using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class UserRole
    {
        public UserRole()
        {
            SupportTickets = new HashSet<SupportTicket>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserRoleCharacteristics = new HashSet<UserRoleCharacteristic>();
        }

        public DateTime EffectiveDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }
        public bool IsActive { get; set; }
        public Guid ClientId { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid SecurityRoleId { get; set; }
        public Guid Id { get; set; }
        public string ExternalSystemId { get; set; }

        public Client Client { get; set; }
        public Department Department { get; set; }
        public SecurityRole SecurityRole { get; set; }
        public User User { get; set; }
        public UserRoleCompliance UserRoleCompliance { get; set; }
        public ICollection<SupportTicket> SupportTickets { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserRoleCharacteristic> UserRoleCharacteristics { get; set; }
    }
}
