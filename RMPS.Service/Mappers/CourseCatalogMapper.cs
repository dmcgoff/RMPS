using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMPS.DataAccess.Entities;
using RMPS.Service.ViewModels;

namespace RMPS.Service.Mappers
{
    public static class CourseCatalogMapper
    {
        public static CourseCatalogItemViewModel ToNewViewModel(this CourseCatalogView source)
        {
            var dest = new CourseCatalogItemViewModel();
            return source.ToViewModel(dest);
        }

        public static CourseCatalogItemViewModel ToViewModel(this CourseCatalogView source, CourseCatalogItemViewModel dest)
        {
            dest.Id = source.Id;
            dest.ModalityId = source.ModalityId;
            dest.ModalityType = source.ModalityType;
            dest.CourseId = source.CourseId;
            dest.CourseName = source.CourseName;
            dest.VariantId = source.VariantId;
            dest.Description = source.Description;
            dest.ReviewDate = source.ReviewDate;
            dest.ReleaseDate = source.ReleaseDate;
            dest.ExpirationDate = source.ExpirationDate;
            dest.Credits = source.Credits;
            dest.CMECert = source.CMECert;
            dest.CEUCert = source.CEUCert;
            dest.RiskSpecific = source.RiskSpecific;
            dest.Setting = source.Setting;
            dest.MedicalRole = source.MedicalRole;
            dest.Specialty = source.Specialty;
            dest.State = source.State;

            return dest;
        }

        public static CourseCatalogView ToNewEntity(this CourseCatalogItemViewModel source)
        {
            var dest = new CourseCatalogView();
            return source.ToEntity(dest);
        }

        public static CourseCatalogView ToEntity(this CourseCatalogItemViewModel source, CourseCatalogView dest)
        {
            dest.Id = source.Id;
            dest.ModalityId = source.ModalityId;
            dest.ModalityType = source.ModalityType;
            dest.CourseId = source.CourseId;
            dest.CourseName = source.CourseName;
            dest.VariantId = source.VariantId;
            dest.Description = source.Description;
            dest.ReviewDate = source.ReviewDate;
            dest.ReleaseDate = source.ReleaseDate;
            dest.ExpirationDate = source.ExpirationDate;
            dest.Credits = source.Credits;
            dest.CMECert = source.CMECert;
            dest.CEUCert = source.CEUCert;
            dest.RiskSpecific = source.RiskSpecific;
            dest.Setting = source.Setting;
            dest.MedicalRole = source.MedicalRole;
            dest.Specialty = source.Specialty;
            dest.State = source.State;

            return dest;
        }
    }
}
