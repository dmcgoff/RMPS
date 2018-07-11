using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using RMPS.Business.Interface;
using RMPS.DataAccess.Entities;
using RMPS.DataAccess.Interface;

namespace RMPS.Business.Logic
{
    public class CourseCatalogService : ICourseCatalogService
    {
        private readonly ICourseCatalogRepository _repository;

        public CourseCatalogService(ICourseCatalogRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<CourseCatalogView> GetCourseCatalog()
        {
            return _repository.GetAll();
        }

        public T GetFilteredCourseCatalog<T>(Func<IQueryable<CourseCatalogView>, T> processQueryable)
        {
            return _repository.GetFilteredCourseCatalog<T>(processQueryable);
        }
    }
}
