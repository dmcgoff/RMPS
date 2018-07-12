using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RMPS.DataAccess.Entities;

namespace RMPS.Business.Interface
{
    public interface ICourseService
    {
        IEnumerable<Modality> GetCourses();
        T GetFilteredCourses<T>(Func<IQueryable<Modality>, T> processQueryable);
    }
}
