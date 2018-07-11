using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicValue
    {
        public CharacteristicValue()
        {
            CharacteristicRestrictions = new HashSet<CharacteristicRestriction>();
            CharacteristicValueParentBaseCharacteristicValues = new HashSet<CharacteristicValueParent>();
            CharacteristicValueParentChildCharacteristicValues = new HashSet<CharacteristicValueParent>();
            CharacteristicValueSubstitutionBaseCharacteristicValues = new HashSet<CharacteristicValueSubstitution>();
            CharacteristicValueSubstitutionSubstitutionCharacteristicValues = new HashSet<CharacteristicValueSubstitution>();
            ModalityVariantCharacteristicValues = new HashSet<ModalityVariantCharacteristicValue>();
            UserCharacteristics = new HashSet<UserCharacteristic>();
            UserRoleCharacteristics = new HashSet<UserRoleCharacteristic>();
        }

        public Guid Id { get; set; }
        public Guid CharacteristicCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public CharacteristicCategory CharacteristicCategory { get; set; }
        public ICollection<CharacteristicRestriction> CharacteristicRestrictions { get; set; }
        public ICollection<CharacteristicValueParent> CharacteristicValueParentBaseCharacteristicValues { get; set; }
        public ICollection<CharacteristicValueParent> CharacteristicValueParentChildCharacteristicValues { get; set; }
        public ICollection<CharacteristicValueSubstitution> CharacteristicValueSubstitutionBaseCharacteristicValues { get; set; }
        public ICollection<CharacteristicValueSubstitution> CharacteristicValueSubstitutionSubstitutionCharacteristicValues { get; set; }
        public ICollection<ModalityVariantCharacteristicValue> ModalityVariantCharacteristicValues { get; set; }
        public ICollection<UserCharacteristic> UserCharacteristics { get; set; }
        public ICollection<UserRoleCharacteristic> UserRoleCharacteristics { get; set; }
    }
}
