using System;

namespace RMPS.DataAccess.Entities
{
    public partial class TenantClient
    {
        public Guid ClientsId { get; set; }
        public Guid TenantsId { get; set; }

        public Client Clients { get; set; }
        public Tenant Tenants { get; set; }
    }
}
