using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionMeasure
    {
        public QuestionMeasure()
        {
            Questions = new HashSet<Question>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
