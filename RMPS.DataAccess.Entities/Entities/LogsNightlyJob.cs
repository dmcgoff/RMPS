using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class LogsNightlyJob
    {
        public LogsNightlyJob()
        {
            LogsCurriculumRecalculations = new HashSet<LogsCurriculumRecalculation>();
            LogsEmailHistories = new HashSet<LogsEmailHistory>();
        }

        public DateTime JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public DateTime RunContextDate { get; set; }
        public DateTime? NextRunContextDate { get; set; }
        public int? NumberOfProcessedUsers { get; set; }
        public string JobLog { get; set; }
        public Guid Id { get; set; }

        public ICollection<LogsCurriculumRecalculation> LogsCurriculumRecalculations { get; set; }
        public ICollection<LogsEmailHistory> LogsEmailHistories { get; set; }
    }
}
