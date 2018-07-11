using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class User
    {
        public User()
        {
            ChatroomUsers = new HashSet<ChatroomUser>();
            EventRegistrations = new HashSet<EventRegistration>();
            LogsCurriculumRecalculations = new HashSet<LogsCurriculumRecalculation>();
            LogsEmailHistories = new HashSet<LogsEmailHistory>();
            LogsUserLogins = new HashSet<LogsUserLogin>();
            RiskAlertNotifications = new HashSet<RiskAlertNotification>();
            SupportTicketAssignedToUsers = new HashSet<SupportTicket>();
            SupportTicketRequestedByUsers = new HashSet<SupportTicket>();
            UserCharacteristics = new HashSet<UserCharacteristic>();
            UserClientCurriculumPlanModalitySubstitutions = new HashSet<UserClientCurriculumPlanModalitySubstitution>();
            UserCredentials = new HashSet<UserCredential>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserCustomFields = new HashSet<UserCustomField>();
            UserModalityLogs = new HashSet<UserModalityLog>();
            UserRoles = new HashSet<UserRole>();
        }

        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationCode { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string AccountDisabledReason { get; set; }
        public DateTime? AccountLockedTime { get; set; }
        public string AdditionalCredentials { get; set; }
        public DateTime? IntroWatchedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool AccountDisabled { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public Guid? ResetPasswordGuid { get; set; }
        public string AdministrativeEmail { get; set; }
        public bool? SendCurriculumAlerts { get; set; }
        public bool? SendMissedEventAlerts { get; set; }
        public bool? SendRiskAlerts { get; set; }
        public Guid Id { get; set; }
        public Guid ChangedById { get; set; }
        public string Salt { get; set; }
        public bool SendToolboxAlerts { get; set; }
        public Guid? StateId { get; set; }
        public Guid? TimeZoneId { get; set; }
        public DateTime? PasswordResetDate { get; set; }
        public string UserName { get; set; }
        public string SecondaryEmailAddress { get; set; }

        public State State { get; set; }
        public TimeZoneMap TimeZone { get; set; }
        public UserCompliance UserCompliance { get; set; }
        public ICollection<ChatroomUser> ChatroomUsers { get; set; }
        public ICollection<EventRegistration> EventRegistrations { get; set; }
        public ICollection<LogsCurriculumRecalculation> LogsCurriculumRecalculations { get; set; }
        public ICollection<LogsEmailHistory> LogsEmailHistories { get; set; }
        public ICollection<LogsUserLogin> LogsUserLogins { get; set; }
        public ICollection<RiskAlertNotification> RiskAlertNotifications { get; set; }
        public ICollection<SupportTicket> SupportTicketAssignedToUsers { get; set; }
        public ICollection<SupportTicket> SupportTicketRequestedByUsers { get; set; }
        public ICollection<UserCharacteristic> UserCharacteristics { get; set; }
        public ICollection<UserClientCurriculumPlanModalitySubstitution> UserClientCurriculumPlanModalitySubstitutions { get; set; }
        public ICollection<UserCredential> UserCredentials { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserCustomField> UserCustomFields { get; set; }
        public ICollection<UserModalityLog> UserModalityLogs { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
