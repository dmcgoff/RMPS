using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionnaireUsage
    {
        public QuestionnaireUsage()
        {
            ModalityVariantQuestionnaires = new HashSet<ModalityVariantQuestionnaire>();
            UserQuestionnaires = new HashSet<UserQuestionnaire>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<ModalityVariantQuestionnaire> ModalityVariantQuestionnaires { get; set; }
        public ICollection<UserQuestionnaire> UserQuestionnaires { get; set; }
    }
}
