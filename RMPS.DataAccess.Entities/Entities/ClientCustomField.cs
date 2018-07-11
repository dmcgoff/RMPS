using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ClientCustomField
    {
        public ClientCustomField()
        {
            UserCustomFields = new HashSet<UserCustomField>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ClientId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public Client Client { get; set; }
        public ICollection<UserCustomField> UserCustomFields { get; set; }
    }
}
