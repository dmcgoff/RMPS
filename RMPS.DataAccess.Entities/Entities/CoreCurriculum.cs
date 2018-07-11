using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CoreCurriculum
    {
        public CoreCurriculum()
        {
            ClientCurriculums = new HashSet<ClientCurriculum>();
            CoreCurriculumPlans = new HashSet<CoreCurriculumPlan>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid CurriculumTypeId { get; set; }

        public CurriculumType CurriculumType { get; set; }
        public ICollection<ClientCurriculum> ClientCurriculums { get; set; }
        public ICollection<CoreCurriculumPlan> CoreCurriculumPlans { get; set; }
    }
}
