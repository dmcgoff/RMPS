using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserCharacteristic
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CharacteristicCategoryId { get; set; }
        public Guid? CharacteristicValueId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public CharacteristicCategory CharacteristicCategory { get; set; }
        public CharacteristicValue CharacteristicValue { get; set; }
        public User User { get; set; }
    }
}
