﻿using Microsoft.EntityFrameworkCore;
using RMPS.DataAccess.Entities;

namespace RMPS.DataAccess.Interface
{
    public interface IRmpsDbContext
    {
        DbSet<Answer> Answers { get; set; }
        DbSet<BillToType> BillToTypes { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<CertificateRequest> CertificateRequests { get; set; }
        DbSet<CertificateTemplate> CertificateTemplates { get; set; }
        DbSet<CertificateTemplateType> CertificateTemplateTypes { get; set; }
        DbSet<CertificationFormat> CertificationFormats { get; set; }
        DbSet<CertificationProvider> CertificationProviders { get; set; }
        DbSet<Certification> Certifications { get; set; }
        DbSet<CertificationType> CertificationTypes { get; set; }
        DbSet<CharacteristicCategory> CharacteristicCategories { get; set; }
        DbSet<CharacteristicRestriction> CharacteristicRestrictions { get; set; }
        DbSet<CharacteristicScope> CharacteristicScopes { get; set; }
        DbSet<CharacteristicType> CharacteristicTypes { get; set; }
        DbSet<CharacteristicValueParent> CharacteristicValueParents { get; set; }
        DbSet<CharacteristicValue> CharacteristicValues { get; set; }
        DbSet<CharacteristicValueSubstitution> CharacteristicValueSubstitutions { get; set; }
        DbSet<Chatroom> Chatrooms { get; set; }
        DbSet<ChatroomUserConnection> ChatroomUserConnections { get; set; }
        DbSet<ChatroomUserMessage> ChatroomUserMessages { get; set; }
        DbSet<ChatroomUser> ChatroomUsers { get; set; }
        DbSet<ClientCurriculumPlanCertificationTypePrice> ClientCurriculumPlanCertificationTypePrices { get; set; }
        DbSet<ClientCurriculumPlanPrerequisite> ClientCurriculumPlanPrerequisites { get; set; }
        DbSet<ClientCurriculumPlanQuestionnaireOverride> ClientCurriculumPlanQuestionnaireOverrides { get; set; }
        DbSet<ClientCurriculumPlan> ClientCurriculumPlans { get; set; }
        DbSet<ClientCurriculum> ClientCurriculums { get; set; }
        DbSet<ClientCustomField> ClientCustomFields { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<CoreCurriculumPlan> CoreCurriculumPlans { get; set; }
        DbSet<CoreCurriculum> CoreCurriculums { get; set; }
        DbSet<CourseCatalogView> CourseCatalogItems { get; set; }
        DbSet<CourseGrouping> CourseGroupings { get; set; }
        DbSet<Credential> Credentials { get; set; }
        DbSet<CurriculumType> CurriculumTypes { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<ElmDataMapping> ElmDataMappings { get; set; }
        DbSet<EmailType> EmailTypes { get; set; }
        DbSet<EventRegistration> EventRegistrations { get; set; }
        DbSet<EventSessionCertification> EventSessionCertifications { get; set; }
        DbSet<EventSessionClient> EventSessionClients { get; set; }
        DbSet<EventSession> EventSessions { get; set; }
        DbSet<EventSessionType> EventSessionTypes { get; set; }
        DbSet<EventSpeaker> EventSpeakers { get; set; }
        DbSet<Faqitem> Faqitems { get; set; }
        DbSet<File> Files { get; set; }
        DbSet<IntroVideo> IntroVideos { get; set; }
        DbSet<LogsCurriculumRecalculation> LogsCurriculumRecalculations { get; set; }
        DbSet<LogsEmailHistory> LogsEmailHistories { get; set; }
        DbSet<LogsNightlyJob> LogsNightlyJobs { get; set; }
        DbSet<LogsUserLogin> LogsUserLogins { get; set; }
        DbSet<MediaObject> MediaObjects { get; set; }
        DbSet<MediaObjectSourceHost> MediaObjectSourceHosts { get; set; }
        DbSet<MediaObjectSource> MediaObjectSources { get; set; }
        DbSet<MediaObjectSourceType> MediaObjectSourceTypes { get; set; }
        DbSet<MigrationHistory> MigrationHistories { get; set; }
        DbSet<Modality> Modalities { get; set; }
        DbSet<ModalityDescriptor> ModalityDescriptors { get; set; }
        DbSet<ModalityStatu> ModalityStatuses { get; set; }
        DbSet<ModalityType> ModalityTypes { get; set; }
        DbSet<ModalityVariantCertification> ModalityVariantCertifications { get; set; }
        DbSet<ModalityVariantCharacteristicValue> ModalityVariantCharacteristicValues { get; set; }
        DbSet<ModalityVariantQuestionnaire> ModalityVariantQuestionnaires { get; set; }
        DbSet<ModalityVariantRule> ModalityVariantRules { get; set; }
        DbSet<ModalityVariant> ModalityVariants { get; set; }
        DbSet<ModalityVariantsLiveEvent> ModalityVariantsLiveEvents { get; set; }
        DbSet<ModalityVariantsRiskAlert> ModalityVariantsRiskAlerts { get; set; }
        DbSet<ModalityVariantState> ModalityVariantStates { get; set; }
        DbSet<ModalityVariantsTest> ModalityVariantsTests { get; set; }
        DbSet<ModalityVariantsWebModule> ModalityVariantsWebModules { get; set; }
        DbSet<PaymentMethod> PaymentMethods { get; set; }
        DbSet<QuestionAnswerCondition> QuestionAnswerConditions { get; set; }
        DbSet<QuestionDisplayType> QuestionDisplayTypes { get; set; }
        DbSet<QuestionMeasure> QuestionMeasures { get; set; }
        DbSet<Questionnaire> Questionnaires { get; set; }
        DbSet<QuestionnaireState> QuestionnaireStates { get; set; }
        DbSet<QuestionnaireType> QuestionnaireTypes { get; set; }
        DbSet<QuestionnaireUsage> QuestionnaireUsages { get; set; }
        DbSet<QuestionnaireVersionQuestionGroup> QuestionnaireVersionQuestionGroups { get; set; }
        DbSet<QuestionnaireVersion> QuestionnaireVersions { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<QuestionType> QuestionTypes { get; set; }
        DbSet<RiskAlertNotification> RiskAlertNotifications { get; set; }
        DbSet<SecurityRole> SecurityRoles { get; set; }
        DbSet<Speaker> Speakers { get; set; }
        DbSet<SpeakerType> SpeakerTypes { get; set; }
        DbSet<State> States { get; set; }
        DbSet<SupportCategory> SupportCategories { get; set; }
        DbSet<SupportSource> SupportSources { get; set; }
        DbSet<SupportTicket> SupportTickets { get; set; }
        DbSet<TakeAway> TakeAways { get; set; }
        DbSet<TenantClient> TenantClients { get; set; }
        DbSet<Tenant> Tenants { get; set; }
        DbSet<TimeZoneMap> TimeZoneMaps { get; set; }
        DbSet<ToolCategory> ToolCategories { get; set; }
        DbSet<Tool> Tools { get; set; }
        DbSet<UserAnswer> UserAnswers { get; set; }
        DbSet<UserCharacteristic> UserCharacteristics { get; set; }
        DbSet<UserClientCurriculumPlanModalitySubstitution> UserClientCurriculumPlanModalitySubstitutions { get; set; }
        DbSet<UserCompliance> UserCompliances { get; set; }
        DbSet<UserCredential> UserCredentials { get; set; }
        DbSet<UserCurriculum> UserCurriculums { get; set; }
        DbSet<UserCustomField> UserCustomFields { get; set; }
        DbSet<UserModalityLog> UserModalityLogs { get; set; }
        DbSet<UserQuestionnaire> UserQuestionnaires { get; set; }
        DbSet<UserQuestionnaireStatusType> UserQuestionnaireStatusTypes { get; set; }
        DbSet<UserRoleCharacteristic> UserRoleCharacteristics { get; set; }
        DbSet<UserRoleCompliance> UserRoleCompliances { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Venue> Venues { get; set; }
        DbSet<Webinar> Webinars { get; set; }
        DbSet<WebModuleSpeaker> WebModuleSpeakers { get; set; }
    }
}