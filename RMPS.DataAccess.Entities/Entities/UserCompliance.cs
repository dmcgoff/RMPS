using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserCompliance
    {
        public int ProgramYearItemsTotal { get; set; }
        public int ProgramYearItemsCompleted { get; set; }
        public double ProgramYearPercentComplete { get; set; }
        public int AvailableItemsTotal { get; set; }
        public double AvailableItemsPercentComplete { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int AvailableItemsCompleted { get; set; }
        public int AvailableItemsLate { get; set; }
        public bool? IsDirty { get; set; }
        public Guid UserId { get; set; }
        public Guid ChangedById { get; set; }

        public User User { get; set; }
    }
}
