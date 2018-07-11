using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionnaireState
    {
        public QuestionnaireState()
        {
            QuestionnaireVersions = new HashSet<QuestionnaireVersion>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<QuestionnaireVersion> QuestionnaireVersions { get; set; }
    }
}
