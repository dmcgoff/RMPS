using System;

namespace RMPS.DataAccess.Entities
{
    public partial class LogsCurriculumRecalculation
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public Guid? LogsNightlyJobId { get; set; }
        public bool WasSuccessful { get; set; }
        public int? ComplianceCalculationDuration { get; set; }
        public int? SendAlertsDuration { get; set; }
        public int? NumberOfCurriculumAlertsSent { get; set; }
        public int? NumberOfRiskAlertNoticesSent { get; set; }
        public int? NumberOfEventSessionMissedSent { get; set; }
        public string CurriculumAlertReason { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public LogsNightlyJob LogsNightlyJob { get; set; }
        public User User { get; set; }
    }
}
