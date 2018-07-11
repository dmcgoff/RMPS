using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Clients = new HashSet<Client>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public string SubDomainPrefix { get; set; }
        public Guid? LogoImageFileId { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string WelcomeMessage { get; set; }
        public string Instructions { get; set; }
        public string Picture { get; set; }

        public File LogoImageFile { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
