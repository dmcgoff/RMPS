using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CurriculumType
    {
        public CurriculumType()
        {
            CoreCurriculums = new HashSet<CoreCurriculum>();
            UserCurriculums = new HashSet<UserCurriculum>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<CoreCurriculum> CoreCurriculums { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
    }
}
