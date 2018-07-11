using System;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicValueParent
    {
        public Guid ChildCharacteristicValueId { get; set; }
        public Guid BaseCharacteristicValueId { get; set; }

        public CharacteristicValue BaseCharacteristicValue { get; set; }
        public CharacteristicValue ChildCharacteristicValue { get; set; }
    }
}
