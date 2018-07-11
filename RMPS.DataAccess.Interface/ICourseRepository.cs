using System;
using System.Collections.Generic;
using RMPS.DataAccess.Entities;

namespace RMPS.DataAccess.Interface
{
    public interface ICourseRepository
    {
        IEnumerable<Modality> GetAllCoures();
    }
}
