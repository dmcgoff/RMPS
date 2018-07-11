using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Tenant
    {
        public Tenant()
        {
            TenantClients = new HashSet<TenantClient>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<TenantClient> TenantClients { get; set; }
    }
}
