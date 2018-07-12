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
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;

        public CourseService(ICourseRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Modality> GetCourses()
        {
            return _repository.GetAllCoures();
        }

        public T GetFilteredCourses<T>(Func<IQueryable<Modality>, T> processQueryable)
        {
            return _repository.GetFilteredCourses<T>(processQueryable);
        }
    }
}
