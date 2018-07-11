using System;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicValueSubstitution
    {
        public Guid SubstitutionCharacteristicValueId { get; set; }
        public Guid BaseCharacteristicValueId { get; set; }

        public CharacteristicValue BaseCharacteristicValue { get; set; }
        public CharacteristicValue SubstitutionCharacteristicValue { get; set; }
    }
}
