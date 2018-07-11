using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class CourseGrouping
    {
        public CourseGrouping()
        {
            ClientCurriculumPlans = new HashSet<ClientCurriculumPlan>();
        }

        public Guid Id { get; set; }
        public Guid ClientCurriculumId { get; set; }
        public string CourseGroupingName { get; set; }
        public string ProgramYear { get; set; }
        public int? NumberOfCoursesInGroup { get; set; }
        public int? NumberOfRequiredCourses { get; set; }

        public ICollection<ClientCurriculumPlan> ClientCurriculumPlans { get; set; }
    }
}
