﻿using System;
using System.Collections.Generic;
using System.Linq;
using RMPS.DataAccess.Entities;

namespace RMPS.DataAccess.Interface
{
    public interface ICourseRepository
    {
        IEnumerable<Modality> GetAllCoures();

        T GetFilteredCourses<T>(Func<IQueryable<Modality>, T> processQueryable);
    }
}
