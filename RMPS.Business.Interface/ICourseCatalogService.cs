using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RMPS.DataAccess.Entities;

namespace RMPS.Business.Interface
{
    public interface ICourseCatalogService
    {
        IEnumerable<CourseCatalogView> GetCourseCatalog();
        T GetFilteredCourseCatalog<T>(Func<IQueryable<CourseCatalogView>, T> processQueryable);
    }
}
