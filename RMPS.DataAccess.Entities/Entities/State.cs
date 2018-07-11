using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class State
    {
        public State()
        {
            Departments = new HashSet<Department>();
            ModalityVariantStates = new HashSet<ModalityVariantState>();
            Users = new HashSet<User>();
            Venues = new HashSet<Venue>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<ModalityVariantState> ModalityVariantStates { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Venue> Venues { get; set; }
    }
}
