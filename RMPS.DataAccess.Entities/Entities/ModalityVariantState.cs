using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantState
    {
        public Guid ModalityVariantId { get; set; }
        public Guid StateId { get; set; }

        public ModalityVariant ModalityVariant { get; set; }
        public State State { get; set; }
    }
}
