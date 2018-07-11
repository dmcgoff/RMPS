using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class IntroVideo
    {
        public IntroVideo()
        {
            Clients = new HashSet<Client>();
        }

        public bool IsDefault { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Name { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid? MediaObjectId { get; set; }

        public MediaObject MediaObject { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
