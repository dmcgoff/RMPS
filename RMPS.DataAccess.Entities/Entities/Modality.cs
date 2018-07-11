using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Modality
    {
        public Modality()
        {
            ClientCurriculumPlans = new HashSet<ClientCurriculumPlan>();
            CoreCurriculumPlans = new HashSet<CoreCurriculumPlan>();
            ModalityVariants = new HashSet<ModalityVariant>();
            UserClientCurriculumPlanModalitySubstitutions = new HashSet<UserClientCurriculumPlanModalitySubstitution>();
            UserCurriculums = new HashSet<UserCurriculum>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid ModalityTypeId { get; set; }
        public Guid? ModalityDescriptorId { get; set; }
        public Guid ModalityStatusId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string CourseNumber { get; set; }

        public ModalityDescriptor ModalityDescriptor { get; set; }
        public ModalityStatu ModalityStatus { get; set; }
        public ModalityType ModalityType { get; set; }
        public ICollection<ClientCurriculumPlan> ClientCurriculumPlans { get; set; }
        public ICollection<CoreCurriculumPlan> CoreCurriculumPlans { get; set; }
        public ICollection<ModalityVariant> ModalityVariants { get; set; }
        public ICollection<UserClientCurriculumPlanModalitySubstitution> UserClientCurriculumPlanModalitySubstitutions { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
    }
}
