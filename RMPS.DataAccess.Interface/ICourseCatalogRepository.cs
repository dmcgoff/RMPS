using System;
using System.Collections.Generic;
using System.Linq;
using RMPS.DataAccess.Entities;

namespace RMPS.DataAccess.Interface
{
    public interface ICourseCatalogRepository
    {
        IEnumerable<CourseCatalogView> GetAll();
        T GetFilteredCourseCatalog<T>(Func<IQueryable<CourseCatalogView>, T> processQueryable);
    }
}
