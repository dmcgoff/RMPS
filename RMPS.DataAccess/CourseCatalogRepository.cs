using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using RMPS.DataAccess.Entities;
using RMPS.DataAccess.Interface;

namespace RMPS.DataAccess
{
    public class CourseCatalogRepository : ICourseCatalogRepository
    {
        private readonly IRmpsDbContext _context;

        public CourseCatalogRepository(IRmpsDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CourseCatalogView> GetAll()
        {
                return _context.CourseCatalogItems;
        }

        public T GetFilteredCourseCatalog<T>(Func<IQueryable<CourseCatalogView>, T> processQueryable)
        {
            return processQueryable(_context.CourseCatalogItems);
        }
    }
}
