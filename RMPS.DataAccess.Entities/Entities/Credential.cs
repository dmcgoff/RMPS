using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Credential
    {
        public Credential()
        {
            UserCredentials = new HashSet<UserCredential>();
        }

        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Sequence { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<UserCredential> UserCredentials { get; set; }
    }
}
