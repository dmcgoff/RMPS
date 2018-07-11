using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            CharacteristicRestrictions = new HashSet<CharacteristicRestriction>();
            UserRoles = new HashSet<UserRole>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<CharacteristicRestriction> CharacteristicRestrictions { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
