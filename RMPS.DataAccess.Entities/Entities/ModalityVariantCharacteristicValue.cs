using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantCharacteristicValue
    {
        public Guid ModalityVariantId { get; set; }
        public Guid CharacteristicValueId { get; set; }

        public CharacteristicValue CharacteristicValue { get; set; }
        public ModalityVariant ModalityVariant { get; set; }
    }
}
