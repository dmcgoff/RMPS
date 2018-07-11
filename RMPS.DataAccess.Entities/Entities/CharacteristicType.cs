using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicType
    {
        public CharacteristicType()
        {
            CharacteristicCategories = new HashSet<CharacteristicCategory>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<CharacteristicCategory> CharacteristicCategories { get; set; }
    }
}
