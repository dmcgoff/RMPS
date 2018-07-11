using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            ModalityVariantQuestionnaires = new HashSet<ModalityVariantQuestionnaire>();
            QuestionnaireVersions = new HashSet<QuestionnaireVersion>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid QuestionnaireTypeId { get; set; }

        public QuestionnaireType QuestionnaireType { get; set; }
        public ICollection<ModalityVariantQuestionnaire> ModalityVariantQuestionnaires { get; set; }
        public ICollection<QuestionnaireVersion> QuestionnaireVersions { get; set; }
    }
}
