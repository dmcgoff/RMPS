using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityDescriptor
    {
        public ModalityDescriptor()
        {
            Modalities = new HashSet<Modality>();
            UserCurriculums = new HashSet<UserCurriculum>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public ICollection<Modality> Modalities { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
    }
}
