using System;

namespace RMPS.DataAccess.Entities
{
    public partial class CharacteristicRestriction
    {
        public Guid Id { get; set; }
        public Guid CharacteristicValueId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? ClientId { get; set; }
        public Guid? SecurityRoleId { get; set; }

        public CharacteristicValue CharacteristicValue { get; set; }
        public Client Client { get; set; }
        public SecurityRole SecurityRole { get; set; }
    }
}
