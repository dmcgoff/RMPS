using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class MediaObjectSource
    {
        public MediaObjectSource()
        {
            MediaObjects = new HashSet<MediaObject>();
        }

        public Guid Id { get; set; }
        public Guid MediaObjectSourceHostId { get; set; }
        public Guid MediaObjectSourceTypeId { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public bool IsSecure { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public MediaObjectSourceHost MediaObjectSourceHost { get; set; }
        public MediaObjectSourceType MediaObjectSourceType { get; set; }
        public ICollection<MediaObject> MediaObjects { get; set; }
    }
}
