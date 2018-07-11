using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserCustomField
    {
        public Guid Id { get; set; }
        public string CustomFieldText { get; set; }
        public Guid UserId { get; set; }
        public Guid ClientCustomFieldId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ClientCustomField ClientCustomField { get; set; }
        public User User { get; set; }
    }
}
