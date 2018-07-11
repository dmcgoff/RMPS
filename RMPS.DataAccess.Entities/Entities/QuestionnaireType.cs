using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionnaireType
    {
        public QuestionnaireType()
        {
            Questionnaires = new HashSet<Questionnaire>();
        }

        public string Name { get; set; }
        public bool AnswersRequired { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<Questionnaire> Questionnaires { get; set; }
    }
}
