using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
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

        public T GetFilteredCourses<T>(Func<IQueryable<Modality>, T> processQueryable)
        {
            return processQueryable(
                _context.Modalities
                        .Include(md => md.ModalityDescriptor)
                        .Include(ms => ms.ModalityStatus)
                        .Include(mt => mt.ModalityType)
            );
        }

    }
}
