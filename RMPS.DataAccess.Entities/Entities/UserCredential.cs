using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserCredential
    {
        public Guid UsersId { get; set; }
        public Guid CredentialsId { get; set; }

        public Credential Credentials { get; set; }
        public User Users { get; set; }
    }
}
