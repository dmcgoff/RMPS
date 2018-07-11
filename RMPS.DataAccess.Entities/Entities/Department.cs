using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Department
    {
        public Department()
        {
            UserCurriculums = new HashSet<UserCurriculum>();
            UserRoles = new HashSet<UserRole>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid ClientId { get; set; }
        public Guid Id { get; set; }
        public Guid? StateId { get; set; }

        public Client Client { get; set; }
        public State State { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
