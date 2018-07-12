using System;

namespace RMPS.Services.Api.ViewModels
{
    public class CourseViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Number { get; set; }


        public Guid TypeId { get; set; }
        public string TypeName { get; set; }

        public Guid? DescriptorId { get; set; }
        public string DescriptorName { get; set; }

        public Guid StatusId { get; set; }
        public string StatusName { get; set; }

        public string Description { get; set; }
        public string Notes { get; set; }


        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public bool IsActive { get; set; }

    }


}
