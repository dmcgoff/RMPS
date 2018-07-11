using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserRoleCompliance
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
        public Guid ChangedById { get; set; }
        public Guid? ClientCurriculumId { get; set; }
        public Guid UserRoleId { get; set; }

        public ClientCurriculum ClientCurriculum { get; set; }
        public UserRole UserRole { get; set; }
    }
}
