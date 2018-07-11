using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityType
    {
        public ModalityType()
        {
            Modalities = new HashSet<Modality>();
            UserCurriculums = new HashSet<UserCurriculum>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<Modality> Modalities { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
    }
}
