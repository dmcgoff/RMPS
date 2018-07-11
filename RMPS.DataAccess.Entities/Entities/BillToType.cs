using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class BillToType
    {
        public BillToType()
        {
            ClientCurriculumPlanCertificationTypePrices = new HashSet<ClientCurriculumPlanCertificationTypePrice>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<ClientCurriculumPlanCertificationTypePrice> ClientCurriculumPlanCertificationTypePrices { get; set; }
    }
}
