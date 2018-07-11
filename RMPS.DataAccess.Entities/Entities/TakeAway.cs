using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class TakeAway
    {
        public TakeAway()
        {
            ModalityVariants = new HashSet<ModalityVariant>();
        }

        public string Name { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int? FileLength { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? FileId { get; set; }
        public Guid Id { get; set; }

        public File File { get; set; }
        public ICollection<ModalityVariant> ModalityVariants { get; set; }
    }
}
