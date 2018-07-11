using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserRoleCharacteristic
    {
        public Guid Id { get; set; }
        public Guid CharacteristicCategoryId { get; set; }
        public Guid? CharacteristicValueId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid UserRoleId { get; set; }

        public CharacteristicCategory CharacteristicCategory { get; set; }
        public CharacteristicValue CharacteristicValue { get; set; }
        public UserRole UserRole { get; set; }
    }
}
