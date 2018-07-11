using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using RMPS.DataAccess.Entities;
using RMPS.DataAccess.Interface;

namespace RMPS.DataAccess
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IRmpsDbContext _context;

        public CourseRepository(IRmpsDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Modality> GetAllCoures()
        {
                return _context.Modalities;
        }
    }
}
