using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantsRiskAlert
    {
        public ModalityVariantsRiskAlert()
        {
            RiskAlertNotifications = new HashSet<RiskAlertNotification>();
        }

        public string Scenario { get; set; }
        public string ResponseOne { get; set; }
        public string ResponseTwo { get; set; }
        public string ResponseThree { get; set; }
        public string Explanation { get; set; }
        public int? BestChoice { get; set; }
        public string CaseTitle { get; set; }
        public Guid Id { get; set; }

        public ModalityVariant IdNavigation { get; set; }
        public ICollection<RiskAlertNotification> RiskAlertNotifications { get; set; }
    }
}
