using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicCategory
    {
        public CharacteristicCategory()
        {
            CharacteristicValues = new HashSet<CharacteristicValue>();
            InverseCharacteristicParent = new HashSet<CharacteristicCategory>();
            UserCharacteristics = new HashSet<UserCharacteristic>();
            UserRoleCharacteristics = new HashSet<UserRoleCharacteristic>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CharacteristicTypeId { get; set; }
        public Guid CharacteristicScopeId { get; set; }
        public bool AllowMultiples { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? CharacteristicParentId { get; set; }

        public CharacteristicCategory CharacteristicParent { get; set; }
        public CharacteristicScope CharacteristicScope { get; set; }
        public CharacteristicType CharacteristicType { get; set; }
        public ICollection<CharacteristicValue> CharacteristicValues { get; set; }
        public ICollection<CharacteristicCategory> InverseCharacteristicParent { get; set; }
        public ICollection<UserCharacteristic> UserCharacteristics { get; set; }
        public ICollection<UserRoleCharacteristic> UserRoleCharacteristics { get; set; }
    }
}
