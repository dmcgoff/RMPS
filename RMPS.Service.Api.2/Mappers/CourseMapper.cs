using RMPS.DataAccess.Entities;
using RMPS.Services.Api.ViewModels;

namespace RMPS.Services.Api.Mappers
{
    public static class CourseMapper
    {
        public static CourseViewModel ToNewViewModel(this Modality source)
        {
            var dest = new CourseViewModel();
            return source.ToViewModel(dest);
        }

        public static CourseViewModel ToViewModel(this Modality source, CourseViewModel dest)
        {
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.Number = source.CourseNumber;

            dest.TypeId = source.ModalityTypeId;
            dest.TypeName = source.ModalityType.Name;
            dest.DescriptorId = source.ModalityDescriptorId;
            dest.DescriptorName = source.ModalityDescriptor.Name;
            dest.StatusId = source.ModalityStatusId;
            dest.StatusName = source.ModalityStatus.Name;

            dest.Description = source.Description;
            dest.Notes = source.Notes;

            dest.CreationDate = source.CreationDate;
            dest.UpdateDate = source.UpdateDate;
            dest.ChangedById = source.ChangedById;
            dest.IsActive = source.IsActive;


            return dest;
        }

        public static Modality ToNewEntity(this CourseViewModel source)
        {
            var dest = new Modality();
            return source.ToEntity(dest);
        }

        public static Modality ToEntity(this CourseViewModel source, Modality dest)
        {
            dest.Id = source.Id;
            dest.Name = source.Name;
            dest.CourseNumber = source.Number;

            dest.ModalityTypeId = source.TypeId;
            dest.ModalityDescriptorId = source.DescriptorId;
            dest.ModalityStatusId = source.StatusId;

            dest.Description = source.Description;
            dest.Notes = source.Notes;

            dest.CreationDate = source.CreationDate;
            dest.UpdateDate = source.UpdateDate;
            dest.ChangedById = source.ChangedById;
            dest.IsActive = source.IsActive;


            return dest;
        }
    }
}
