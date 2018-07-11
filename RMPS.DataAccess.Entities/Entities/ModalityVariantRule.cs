using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantRule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public int? Weight { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid ModalityVariantId { get; set; }

        public ModalityVariant ModalityVariant { get; set; }
    }
}
