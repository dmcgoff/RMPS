using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Client
    {
        public Client()
        {
            CertificateRequests = new HashSet<CertificateRequest>();
            CharacteristicRestrictions = new HashSet<CharacteristicRestriction>();
            ClientCurriculums = new HashSet<ClientCurriculum>();
            ClientCustomFields = new HashSet<ClientCustomField>();
            Departments = new HashSet<Department>();
            EventSessionClients = new HashSet<EventSessionClient>();
            InverseParent = new HashSet<Client>();
            LogsEmailHistories = new HashSet<LogsEmailHistory>();
            SupportTickets = new HashSet<SupportTicket>();
            TenantClients = new HashSet<TenantClient>();
            UserCurriculums = new HashSet<UserCurriculum>();
            UserRoles = new HashSet<UserRole>();
            Venues = new HashSet<Venue>();
        }

        public string Name { get; set; }
        public string Website { get; set; }
        public bool RestrictEventsToClientSpecificOnly { get; set; }
        public bool AutomaticCmerequest { get; set; }
        public Guid? BrandId { get; set; }
        public string FromPrefix { get; set; }
        public bool? SendCurriculumAlerts { get; set; }
        public bool? SendMissedEventAlerts { get; set; }
        public bool? SendRiskAlerts { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ParticipantMessage { get; set; }
        public Guid ChangedById { get; set; }
        public bool HasToolbox { get; set; }
        public bool SendToolboxAlerts { get; set; }
        public Guid Id { get; set; }
        public Guid? IntroVideoId { get; set; }
        public string EmailSignature { get; set; }
        public string ExternalSupportId { get; set; }
        public bool PreRegistration { get; set; }
        public bool SelfRegistration { get; set; }
        public Guid? ParentId { get; set; }
        public bool ShowPreviousProgramYears { get; set; }
        public string ElmClientCode { get; set; }

        public Brand Brand { get; set; }
        public IntroVideo IntroVideo { get; set; }
        public Client Parent { get; set; }
        public ICollection<CertificateRequest> CertificateRequests { get; set; }
        public ICollection<CharacteristicRestriction> CharacteristicRestrictions { get; set; }
        public ICollection<ClientCurriculum> ClientCurriculums { get; set; }
        public ICollection<ClientCustomField> ClientCustomFields { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<EventSessionClient> EventSessionClients { get; set; }
        public ICollection<Client> InverseParent { get; set; }
        public ICollection<LogsEmailHistory> LogsEmailHistories { get; set; }
        public ICollection<SupportTicket> SupportTickets { get; set; }
        public ICollection<TenantClient> TenantClients { get; set; }
        public ICollection<UserCurriculum> UserCurriculums { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Venue> Venues { get; set; }
    }
}
