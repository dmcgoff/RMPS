using System;

namespace RMPS.DataAccess.Entities
{
    public partial class Faqitem
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
    }
}
