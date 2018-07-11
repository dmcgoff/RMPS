using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class UserClientCurriculumPlanModalitySubstitution
    {
        public UserClientCurriculumPlanModalitySubstitution()
        {
            UserCurriculums = new HashSet<UserCurriculum>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClientCurriculumPlanId { get; set; }
        public Guid ModalityId { get; set; }

        public ClientCurriculumPlan ClientCurriculumPlan { get; set; }
        public Modality Modality { get; set; }
        public User User { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
    }
}
