using Microsoft.EntityFrameworkCore;
using RMPS.DataAccess.Entities;
using RMPS.DataAccess.Interface;

namespace RMPS.DataAccess
{
    public partial class RmpsDbContext : DbContext, IRmpsDbContext
    {
        public RmpsDbContext()
        {
        }

        public RmpsDbContext(DbContextOptions<RmpsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CourseCatalogView> CourseCatalogItems { get; set; }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<BillToType> BillToTypes { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CertificateRequest> CertificateRequests { get; set; }
        public virtual DbSet<CertificateTemplate> CertificateTemplates { get; set; }
        public virtual DbSet<CertificateTemplateType> CertificateTemplateTypes { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<CertificationFormat> CertificationFormats { get; set; }
        public virtual DbSet<CertificationProvider> CertificationProviders { get; set; }
        public virtual DbSet<CertificationType> CertificationTypes { get; set; }
        public virtual DbSet<CharacteristicCategory> CharacteristicCategories { get; set; }
        public virtual DbSet<CharacteristicRestriction> CharacteristicRestrictions { get; set; }
        public virtual DbSet<CharacteristicScope> CharacteristicScopes { get; set; }
        public virtual DbSet<CharacteristicType> CharacteristicTypes { get; set; }
        public virtual DbSet<CharacteristicValue> CharacteristicValues { get; set; }
        public virtual DbSet<CharacteristicValueParent> CharacteristicValueParents { get; set; }
        public virtual DbSet<CharacteristicValueSubstitution> CharacteristicValueSubstitutions { get; set; }
        public virtual DbSet<Chatroom> Chatrooms { get; set; }
        public virtual DbSet<ChatroomUser> ChatroomUsers { get; set; }
        public virtual DbSet<ChatroomUserConnection> ChatroomUserConnections { get; set; }
        public virtual DbSet<ChatroomUserMessage> ChatroomUserMessages { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientCurriculum> ClientCurriculums { get; set; }
        public virtual DbSet<ClientCurriculumPlan> ClientCurriculumPlans { get; set; }
        public virtual DbSet<ClientCurriculumPlanCertificationTypePrice> ClientCurriculumPlanCertificationTypePrices { get; set; }
        public virtual DbSet<ClientCurriculumPlanPrerequisite> ClientCurriculumPlanPrerequisites { get; set; }
        public virtual DbSet<ClientCurriculumPlanQuestionnaireOverride> ClientCurriculumPlanQuestionnaireOverrides { get; set; }
        public virtual DbSet<ClientCustomField> ClientCustomFields { get; set; }
        public virtual DbSet<CoreCurriculum> CoreCurriculums { get; set; }
        public virtual DbSet<CoreCurriculumPlan> CoreCurriculumPlans { get; set; }
        public virtual DbSet<CourseGrouping> CourseGroupings { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<CurriculumType> CurriculumTypes { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<ElmDataMapping> ElmDataMappings { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }
        public virtual DbSet<EventSession> EventSessions { get; set; }
        public virtual DbSet<EventSessionCertification> EventSessionCertifications { get; set; }
        public virtual DbSet<EventSessionClient> EventSessionClients { get; set; }
        public virtual DbSet<EventSessionType> EventSessionTypes { get; set; }
        public virtual DbSet<EventSpeaker> EventSpeakers { get; set; }
        public virtual DbSet<Faqitem> Faqitems { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<IntroVideo> IntroVideos { get; set; }
        public virtual DbSet<LogsCurriculumRecalculation> LogsCurriculumRecalculations { get; set; }
        public virtual DbSet<LogsEmailHistory> LogsEmailHistories { get; set; }
        public virtual DbSet<LogsNightlyJob> LogsNightlyJobs { get; set; }
        public virtual DbSet<LogsUserLogin> LogsUserLogins { get; set; }
        public virtual DbSet<MediaObject> MediaObjects { get; set; }
        public virtual DbSet<MediaObjectSource> MediaObjectSources { get; set; }
        public virtual DbSet<MediaObjectSourceHost> MediaObjectSourceHosts { get; set; }
        public virtual DbSet<MediaObjectSourceType> MediaObjectSourceTypes { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<Modality> Modalities { get; set; }
        public virtual DbSet<ModalityDescriptor> ModalityDescriptors { get; set; }
        public virtual DbSet<ModalityStatu> ModalityStatuses { get; set; }
        public virtual DbSet<ModalityType> ModalityTypes { get; set; }
        public virtual DbSet<ModalityVariant> ModalityVariants { get; set; }
        public virtual DbSet<ModalityVariantCertification> ModalityVariantCertifications { get; set; }
        public virtual DbSet<ModalityVariantCharacteristicValue> ModalityVariantCharacteristicValues { get; set; }
        public virtual DbSet<ModalityVariantQuestionnaire> ModalityVariantQuestionnaires { get; set; }
        public virtual DbSet<ModalityVariantRule> ModalityVariantRules { get; set; }
        public virtual DbSet<ModalityVariantsLiveEvent> ModalityVariantsLiveEvents { get; set; }
        public virtual DbSet<ModalityVariantsRiskAlert> ModalityVariantsRiskAlerts { get; set; }
        public virtual DbSet<ModalityVariantState> ModalityVariantStates { get; set; }
        public virtual DbSet<ModalityVariantsTest> ModalityVariantsTests { get; set; }
        public virtual DbSet<ModalityVariantsWebModule> ModalityVariantsWebModules { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswerCondition> QuestionAnswerConditions { get; set; }
        public virtual DbSet<QuestionDisplayType> QuestionDisplayTypes { get; set; }
        public virtual DbSet<QuestionMeasure> QuestionMeasures { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionnaireState> QuestionnaireStates { get; set; }
        public virtual DbSet<QuestionnaireType> QuestionnaireTypes { get; set; }
        public virtual DbSet<QuestionnaireUsage> QuestionnaireUsages { get; set; }
        public virtual DbSet<QuestionnaireVersion> QuestionnaireVersions { get; set; }
        public virtual DbSet<QuestionnaireVersionQuestionGroup> QuestionnaireVersionQuestionGroups { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<RiskAlertNotification> RiskAlertNotifications { get; set; }
        public virtual DbSet<SecurityRole> SecurityRoles { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<SpeakerType> SpeakerTypes { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<SupportCategory> SupportCategories { get; set; }
        public virtual DbSet<SupportSource> SupportSources { get; set; }
        public virtual DbSet<SupportTicket> SupportTickets { get; set; }
        public virtual DbSet<TakeAway> TakeAways { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }
        public virtual DbSet<TenantClient> TenantClients { get; set; }
        public virtual DbSet<TimeZoneMap> TimeZoneMaps { get; set; }
        public virtual DbSet<Tool> Tools { get; set; }
        public virtual DbSet<ToolCategory> ToolCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<UserCharacteristic> UserCharacteristics { get; set; }
        public virtual DbSet<UserClientCurriculumPlanModalitySubstitution> UserClientCurriculumPlanModalitySubstitutions { get; set; }
        public virtual DbSet<UserCompliance> UserCompliances { get; set; }
        public virtual DbSet<UserCredential> UserCredentials { get; set; }
        public virtual DbSet<UserCurriculum> UserCurriculums { get; set; }
        public virtual DbSet<UserCustomField> UserCustomFields { get; set; }
        public virtual DbSet<UserModalityLog> UserModalityLogs { get; set; }
        public virtual DbSet<UserQuestionnaire> UserQuestionnaires { get; set; }
        public virtual DbSet<UserQuestionnaireStatusType> UserQuestionnaireStatusTypes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleCharacteristic> UserRoleCharacteristics { get; set; }
        public virtual DbSet<UserRoleCompliance> UserRoleCompliances { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        public virtual DbSet<Webinar> Webinars { get; set; }
        public virtual DbSet<WebModuleSpeaker> WebModuleSpeakers { get; set; }

        // Unable to generate entity type for table 'dbo.UserRoleCharacteristicsAggregation'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ARKSDatabaseStage;Integrated Security=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasIndex(e => e.QuestionId)
                    .HasName("IX_FK_AnswerQuestion");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerQuestion");
            });

            modelBuilder.Entity<BillToType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.LogoImageFileId)
                    .HasName("IX_LogoImageFileId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Instructions).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrimaryColor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SecondaryColor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubDomainPrefix).HasMaxLength(63);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WelcomeMessage)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.LogoImageFile)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.LogoImageFileId)
                    .HasConstraintName("FK_dbo.Brands_dbo.Files_LogoImageFileId");
            });

            modelBuilder.Entity<CertificateRequest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.RequestDate)
                    .HasName("CX_CertificateRequests_RequestDate")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.UserModalityLogId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseCredits).HasColumnType("decimal(9, 5)");

                entity.Property(e => e.CourseLocation).HasMaxLength(250);

                entity.Property(e => e.CourseName).HasMaxLength(250);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FulfillmentDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.StudentName).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CertificateTemplate)
                    .WithMany(p => p.CertificateRequests)
                    .HasForeignKey(d => d.CertificateTemplateId)
                    .HasConstraintName("FK_CertificateRequests_CertificateTemplates");

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.CertificateRequests)
                    .HasForeignKey(d => d.CertificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateRequests_Certifications");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CertificateRequests)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateRequests_Clients");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.CertificateRequests)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateRequests_PaymentMethods");

                entity.HasOne(d => d.UserModalityLog)
                    .WithMany(p => p.CertificateRequests)
                    .HasForeignKey(d => d.UserModalityLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateRequests_UserModalityLogs");
            });

            modelBuilder.Entity<CertificateTemplate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CertificateTemplateType)
                    .WithMany(p => p.CertificateTemplates)
                    .HasForeignKey(d => d.CertificateTemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTemplates_CertificateTemplateTypes");

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.CertificateTemplates)
                    .HasForeignKey(d => d.CertificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTemplates_Certifications");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.CertificateTemplates)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTemplates_Files");
            });

            modelBuilder.Entity<CertificateTemplateType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Certification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CertificationFormat)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.CertificationFormatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certifications_CertificationFormats");

                entity.HasOne(d => d.CertificationProvider)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.CertificationProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certifications_CertificationProviders");

                entity.HasOne(d => d.CertificationType)
                    .WithMany(p => p.Certifications)
                    .HasForeignKey(d => d.CertificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Certifications_CertificationTypes");
            });

            modelBuilder.Entity<CertificationFormat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CertificationProvider>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CertificationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CharacteristicCategory>(entity =>
            {
                entity.HasIndex(e => e.CharacteristicParentId)
                    .HasName("IX_CharacteristicParentId");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CharacteristicParent)
                    .WithMany(p => p.InverseCharacteristicParent)
                    .HasForeignKey(d => d.CharacteristicParentId)
                    .HasConstraintName("FK_dbo.CharacteristicCategories_dbo.CharacteristicCategories_CharacteristicParentId");

                entity.HasOne(d => d.CharacteristicScope)
                    .WithMany(p => p.CharacteristicCategories)
                    .HasForeignKey(d => d.CharacteristicScopeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicCategories_CharacteristicScopes");

                entity.HasOne(d => d.CharacteristicType)
                    .WithMany(p => p.CharacteristicCategories)
                    .HasForeignKey(d => d.CharacteristicTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicCategories_CharacteristicTypes");
            });

            modelBuilder.Entity<CharacteristicRestriction>(entity =>
            {
                entity.HasIndex(e => e.CharacteristicValueId)
                    .HasName("IDX_CharacteristicValueId");

                entity.HasIndex(e => new { e.CharacteristicValueId, e.ClientId, e.SecurityRoleId })
                    .HasName("IDX_CharacteristicValueId_ClientId_SecurityRoleId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CharacteristicValue)
                    .WithMany(p => p.CharacteristicRestrictions)
                    .HasForeignKey(d => d.CharacteristicValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicRestrictions_CharacteristicValues");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CharacteristicRestrictions)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_CharacteristicRestrictions_Client");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.CharacteristicRestrictions)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .HasConstraintName("FK_CharacteristicRestrictions_SecurityRole");
            });

            modelBuilder.Entity<CharacteristicScope>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CharacteristicType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CharacteristicValue>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.CharacteristicCategoryId })
                    .HasName("IDX_Name_Category");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CharacteristicCategory)
                    .WithMany(p => p.CharacteristicValues)
                    .HasForeignKey(d => d.CharacteristicCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicCategoryCharacteristicValues");
            });

            modelBuilder.Entity<CharacteristicValueParent>(entity =>
            {
                entity.HasKey(e => new { e.ChildCharacteristicValueId, e.BaseCharacteristicValueId });

                entity.HasIndex(e => e.BaseCharacteristicValueId)
                    .HasName("IX_BaseCharacteristicValueId");

                entity.HasIndex(e => e.ChildCharacteristicValueId)
                    .HasName("IX_ChildCharacteristicValueId");

                entity.HasOne(d => d.BaseCharacteristicValue)
                    .WithMany(p => p.CharacteristicValueParentBaseCharacteristicValues)
                    .HasForeignKey(d => d.BaseCharacteristicValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CharacteristicValueParents_dbo.CharacteristicValues_BaseCharacteristicValueId");

                entity.HasOne(d => d.ChildCharacteristicValue)
                    .WithMany(p => p.CharacteristicValueParentChildCharacteristicValues)
                    .HasForeignKey(d => d.ChildCharacteristicValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.CharacteristicValueParents_dbo.CharacteristicValues_ChildCharacteristicValueId");
            });

            modelBuilder.Entity<CharacteristicValueSubstitution>(entity =>
            {
                entity.HasKey(e => new { e.SubstitutionCharacteristicValueId, e.BaseCharacteristicValueId });

                entity.HasOne(d => d.BaseCharacteristicValue)
                    .WithMany(p => p.CharacteristicValueSubstitutionBaseCharacteristicValues)
                    .HasForeignKey(d => d.BaseCharacteristicValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicValueSubstitutions_SubstitutionCharacteristicValue");

                entity.HasOne(d => d.SubstitutionCharacteristicValue)
                    .WithMany(p => p.CharacteristicValueSubstitutionSubstitutionCharacteristicValues)
                    .HasForeignKey(d => d.SubstitutionCharacteristicValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacteristicValueSubstitutions_BaseCharacteristicValue");
            });

            modelBuilder.Entity<Chatroom>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChatroomUser>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Chatroom)
                    .WithMany(p => p.ChatroomUsers)
                    .HasForeignKey(d => d.ChatroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatroomUsers_Chatrooms");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ChatroomUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatroomUsers_Users");
            });

            modelBuilder.Entity<ChatroomUserConnection>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConnectionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChatroomUser)
                    .WithMany(p => p.ChatroomUserConnections)
                    .HasForeignKey(d => d.ChatroomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatroomUserConnections_ChatroomUsers");
            });

            modelBuilder.Entity<ChatroomUserMessage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ChatroomUser)
                    .WithMany(p => p.ChatroomUserMessages)
                    .HasForeignKey(d => d.ChatroomUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatroomUserMessages_ChatroomUsers");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("IX_FK_ClientBrand");

                entity.HasIndex(e => e.IntroVideoId)
                    .HasName("IX_FK_ClientIntroVideo");

                entity.HasIndex(e => e.IsActive)
                    .HasName("IDX_IsActive");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutomaticCmerequest).HasColumnName("AutomaticCMERequest");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalSupportId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromPrefix).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendCurriculumAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendMissedEventAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendRiskAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_ClientBrand");

                entity.HasOne(d => d.IntroVideo)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IntroVideoId)
                    .HasConstraintName("FK_ClientIntroVideo");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.Clients_dbo.Clients_ParentId");
            });

            modelBuilder.Entity<ClientCurriculum>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_ClientClientCurriculum");

                entity.HasIndex(e => e.CoreCurriculumId)
                    .HasName("IX_FK_ClientCurriculumCoreCurriculum");

                entity.HasIndex(e => e.StartDate)
                    .HasName("IDX_StartDate");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AudienceExpression).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCurriculums)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientClientCurriculum");

                entity.HasOne(d => d.CoreCurriculum)
                    .WithMany(p => p.ClientCurriculums)
                    .HasForeignKey(d => d.CoreCurriculumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumCoreCurriculum");
            });

            modelBuilder.Entity<ClientCurriculumPlan>(entity =>
            {
                entity.HasIndex(e => e.ClientCurriculumId)
                    .HasName("IX_FK_ClientCurriculumClientCurriculumPlan");

                entity.HasIndex(e => e.CourseGroupingId)
                    .HasName("IX_CourseGrouping_Id");

                entity.HasIndex(e => e.ModalityId)
                    .HasName("IX_FK_ModalityClientCurriculumPlan");

                entity.HasIndex(e => e.StartDate)
                    .HasName("IDX_StartDate");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AudienceExpression).IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CourseGroupingId).HasColumnName("CourseGrouping_Id");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GracePeriodDate).HasColumnType("datetime");

                entity.Property(e => e.PreRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculum)
                    .WithMany(p => p.ClientCurriculumPlans)
                    .HasForeignKey(d => d.ClientCurriculumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumClientCurriculumPlan");

                entity.HasOne(d => d.CourseGrouping)
                    .WithMany(p => p.ClientCurriculumPlans)
                    .HasForeignKey(d => d.CourseGroupingId)
                    .HasConstraintName("FK_dbo.ClientCurriculumPlans_dbo.CourseGroupings_CourseGrouping_Id");

                entity.HasOne(d => d.Modality)
                    .WithMany(p => p.ClientCurriculumPlans)
                    .HasForeignKey(d => d.ModalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityClientCurriculumPlan");
            });

            modelBuilder.Entity<ClientCurriculumPlanCertificationTypePrice>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ClientCurriculumPlanId, e.CertificationTypeId })
                    .HasName("CX_ClientCurriculumPlanCertificationTypePrices_ClientCurriculumPlanId_CertificationTypeId")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.BillToType)
                    .WithMany(p => p.ClientCurriculumPlanCertificationTypePrices)
                    .HasForeignKey(d => d.BillToTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanCertificationTypePrices_BillToTypes");

                entity.HasOne(d => d.CertificationType)
                    .WithMany(p => p.ClientCurriculumPlanCertificationTypePrices)
                    .HasForeignKey(d => d.CertificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanCertificationTypePrices_CertificationTypes");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.ClientCurriculumPlanCertificationTypePrices)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanCertificationTypePrices_ClientCurriculumPlans");
            });

            modelBuilder.Entity<ClientCurriculumPlanPrerequisite>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.ClientCurriculumPlanPrerequisiteClientCurriculumPlans)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanPrerequisites_ClientCurriculumPlan");

                entity.HasOne(d => d.ClientCurriculumPlanPrerequisiteNavigation)
                    .WithMany(p => p.ClientCurriculumPlanPrerequisiteClientCurriculumPlanPrerequisiteNavigations)
                    .HasForeignKey(d => d.ClientCurriculumPlanPrerequisiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanPrerequisites_ClientCurriculumPlans_Prerequisite");
            });

            modelBuilder.Entity<ClientCurriculumPlanQuestionnaireOverride>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.ClientCurriculumPlanQuestionnaireOverrides)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanQuestionnaireOverrides_ClientCurriculumPlans");
            });

            modelBuilder.Entity<ClientCustomField>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_ClientId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientCustomFields)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_dbo.ClientCustomFields_dbo.Clients_ClientId");
            });

            modelBuilder.Entity<CoreCurriculum>(entity =>
            {
                entity.HasIndex(e => e.CurriculumTypeId)
                    .HasName("IX_FK_CoreCurriculumCurriculumType");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CurriculumType)
                    .WithMany(p => p.CoreCurriculums)
                    .HasForeignKey(d => d.CurriculumTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreCurriculumCurriculumType");
            });

            modelBuilder.Entity<CoreCurriculumPlan>(entity =>
            {
                entity.HasIndex(e => e.CoreCurriculumId)
                    .HasName("IX_FK_CoreCurriculumPlanCoreCurriculum");

                entity.HasIndex(e => e.ModalityId)
                    .HasName("IX_FK_CoreCurriculumPlanModality");

                entity.HasIndex(e => new { e.CoreCurriculumId, e.ModalityId })
                    .HasName("IDX_CoreCurriculumPlan_CoreCurriculumId_ModalityId");

                entity.HasIndex(e => new { e.CoreCurriculumId, e.StartDate })
                    .HasName("IDX_CoreCurriculumPlan_StartDate");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.CoreCurriculum)
                    .WithMany(p => p.CoreCurriculumPlans)
                    .HasForeignKey(d => d.CoreCurriculumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreCurriculumPlanCoreCurriculum");

                entity.HasOne(d => d.Modality)
                    .WithMany(p => p.CoreCurriculumPlans)
                    .HasForeignKey(d => d.ModalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CoreCurriculumPlanModality");
            });

            modelBuilder.Entity<CourseGrouping>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CourseGroupingName).HasMaxLength(200);
            });

            modelBuilder.Entity<Credential>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurriculumType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_DepartmentClient");

                entity.HasIndex(e => e.IsActive)
                    .HasName("IDX_IsActive");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_FK_DepartmentState");

                entity.HasIndex(e => new { e.ClientId, e.Name })
                    .HasName("IDX_ClientId_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentClient");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_DepartmentState");
            });

            modelBuilder.Entity<ElmDataMapping>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ArksValue).IsRequired();

                entity.Property(e => e.ElmMappingType).IsRequired();

                entity.Property(e => e.ElmValue).IsRequired();
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventRegistration>(entity =>
            {
                entity.HasIndex(e => e.EventSessionId)
                    .HasName("IX_FK_RegistrationEventSession");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_RegistrationUser");

                entity.HasIndex(e => new { e.UserId, e.EventSessionId })
                    .HasName("IDX_UserId_EventSessionID_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.EventRegistrations)
                    .HasForeignKey(d => d.CertificationId)
                    .HasConstraintName("FK_EventRegistrations_Certifications");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.EventRegistrations)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .HasConstraintName("FK_EventRegistrationsClientCurriculumPlans");

                entity.HasOne(d => d.EventSession)
                    .WithMany(p => p.EventRegistrations)
                    .HasForeignKey(d => d.EventSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationEventSession");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EventRegistrations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationUser");
            });

            modelBuilder.Entity<EventSession>(entity =>
            {
                entity.HasIndex(e => e.AudienceVenueId)
                    .HasName("IX_FK_EventPresentationVenue");

                entity.HasIndex(e => e.EndTime)
                    .HasName("IDX_EndTime");

                entity.HasIndex(e => e.Guid)
                    .HasName("IDX_Guid")
                    .IsUnique();

                entity.HasIndex(e => e.LiveEventId)
                    .HasName("IX_FK_LiveEventEventSession");

                entity.HasIndex(e => e.StartTime)
                    .HasName("IDX_StartTime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AudienceVenue)
                    .WithMany(p => p.EventSessionAudienceVenues)
                    .HasForeignKey(d => d.AudienceVenueId)
                    .HasConstraintName("FK_EventPresentationAudienceVenue");

                entity.HasOne(d => d.EventSessionType)
                    .WithMany(p => p.EventSessions)
                    .HasForeignKey(d => d.EventSessionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSessionType");

                entity.HasOne(d => d.LiveEvent)
                    .WithMany(p => p.EventSessions)
                    .HasForeignKey(d => d.LiveEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LiveEventEventSession");

                entity.HasOne(d => d.MediaObject)
                    .WithMany(p => p.EventSessions)
                    .HasForeignKey(d => d.MediaObjectId)
                    .HasConstraintName("FK_EventSessions_MediaObjects");

                entity.HasOne(d => d.SpeakerVenue)
                    .WithMany(p => p.EventSessionSpeakerVenues)
                    .HasForeignKey(d => d.SpeakerVenueId)
                    .HasConstraintName("FK_EventPresentationSpeakerVenue");

                entity.HasOne(d => d.Webinar)
                    .WithMany(p => p.EventSessions)
                    .HasForeignKey(d => d.WebinarId)
                    .HasConstraintName("FK_EventSessions_Webinars");
            });

            modelBuilder.Entity<EventSessionCertification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.EventSessionCertifications)
                    .HasForeignKey(d => d.CertificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSessionCertifications_Certifications");

                entity.HasOne(d => d.EventSession)
                    .WithMany(p => p.EventSessionCertifications)
                    .HasForeignKey(d => d.EventSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSessionCertifications_EventSessions");
            });

            modelBuilder.Entity<EventSessionClient>(entity =>
            {
                entity.HasKey(e => new { e.ClientsId, e.EventSessionsId });

                entity.ToTable("EventSessionClient");

                entity.HasIndex(e => e.ClientsId)
                    .HasName("IX_FK_EventSessionClient_Client");

                entity.Property(e => e.ClientsId).HasColumnName("Clients_Id");

                entity.Property(e => e.EventSessionsId).HasColumnName("EventSessions_Id");

                entity.HasOne(d => d.Clients)
                    .WithMany(p => p.EventSessionClients)
                    .HasForeignKey(d => d.ClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSessionClient_Client");

                entity.HasOne(d => d.EventSessions)
                    .WithMany(p => p.EventSessionClients)
                    .HasForeignKey(d => d.EventSessionsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSessionClient_EventSession");
            });

            modelBuilder.Entity<EventSessionType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventSpeaker>(entity =>
            {
                entity.HasKey(e => new { e.EventsId, e.SpeakersId });

                entity.ToTable("EventSpeaker");

                entity.HasIndex(e => e.SpeakersId)
                    .HasName("IX_FK_EventSpeaker_Speaker");

                entity.Property(e => e.EventsId).HasColumnName("Events_Id");

                entity.Property(e => e.SpeakersId).HasColumnName("Speakers_Id");

                entity.HasOne(d => d.Events)
                    .WithMany(p => p.EventSpeakers)
                    .HasForeignKey(d => d.EventsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSpeaker_Event");

                entity.HasOne(d => d.Speakers)
                    .WithMany(p => p.EventSpeakers)
                    .HasForeignKey(d => d.SpeakersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventSpeaker_Speaker");
            });

            modelBuilder.Entity<Faqitem>(entity =>
            {
                entity.ToTable("FAQItems");

                entity.HasIndex(e => e.Question)
                    .HasName("IDX_Question_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Answer).IsRequired();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bytes).IsRequired();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Hash).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IntroVideo>(entity =>
            {
                entity.HasIndex(e => e.IsDefault)
                    .HasName("IDX_IsDefault");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.MediaObject)
                    .WithMany(p => p.IntroVideos)
                    .HasForeignKey(d => d.MediaObjectId)
                    .HasConstraintName("FK_IntroVideos_MediaObjects");
            });

            modelBuilder.Entity<LogsCurriculumRecalculation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Logs_CurriculumRecalculations");

                entity.HasIndex(e => e.Date)
                    .HasName("CX_Logs_CurriculumRecalculations_Date")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CurriculumAlertReason).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LogsNightlyJobId).HasColumnName("Logs_NightlyJobId");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.LogsNightlyJob)
                    .WithMany(p => p.LogsCurriculumRecalculations)
                    .HasForeignKey(d => d.LogsNightlyJobId)
                    .HasConstraintName("FK_Logs_CurriculumRecalculations_Logs_NightlyJob");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogsCurriculumRecalculations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_CurriculumRecalculations_Users");
            });

            modelBuilder.Entity<LogsEmailHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Logs_EmailHistory");

                entity.HasIndex(e => e.CreationDate)
                    .HasName("CX_Logs_EmailHistory_CreationDate")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.RecipientUserId);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LogsNightlyJobId).HasColumnName("Logs_NightlyJobId");

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.RecipientEmailAddress).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LogsEmailHistories)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Logs_EmailHistory_Clients");

                entity.HasOne(d => d.EmailType)
                    .WithMany(p => p.LogsEmailHistories)
                    .HasForeignKey(d => d.EmailTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_EmailHistory_AlertType");

                entity.HasOne(d => d.LogsNightlyJob)
                    .WithMany(p => p.LogsEmailHistories)
                    .HasForeignKey(d => d.LogsNightlyJobId)
                    .HasConstraintName("FK_Logs_EmailHistory_Logs_NightlyJob");

                entity.HasOne(d => d.RecipientUser)
                    .WithMany(p => p.LogsEmailHistories)
                    .HasForeignKey(d => d.RecipientUserId)
                    .HasConstraintName("FK_Logs_EmailHistory_Users");
            });

            modelBuilder.Entity<LogsNightlyJob>(entity =>
            {
                entity.ToTable("Logs_NightlyJob");

                entity.HasIndex(e => e.JobStartDate)
                    .HasName("IDX_JobStartDate");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.JobEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobLog).IsUnicode(false);

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.NextRunContextDate).HasColumnType("datetime");

                entity.Property(e => e.RunContextDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogsUserLogin>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Logs_UserLogins");

                entity.HasIndex(e => e.LoginTime)
                    .HasName("CX_Logs_UserLogins_LoginTime")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.BrowserIpaddress)
                    .HasColumnName("BrowserIPAddress")
                    .IsUnicode(false);

                entity.Property(e => e.BrowserType).IsUnicode(false);

                entity.Property(e => e.BrowserVersion).IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogsUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Logs_UserLogins");
            });

            modelBuilder.Entity<MediaObject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Path).HasMaxLength(300);

                entity.Property(e => e.PlaceholderImagePath).HasMaxLength(300);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.MediaObjectSource)
                    .WithMany(p => p.MediaObjects)
                    .HasForeignKey(d => d.MediaObjectSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaObjects_MediaObjectSources");
            });

            modelBuilder.Entity<MediaObjectSource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.MediaObjectSourceHost)
                    .WithMany(p => p.MediaObjectSources)
                    .HasForeignKey(d => d.MediaObjectSourceHostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaObjectSources_MediaObjectSourceHosts");

                entity.HasOne(d => d.MediaObjectSourceType)
                    .WithMany(p => p.MediaObjectSources)
                    .HasForeignKey(d => d.MediaObjectSourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MediaObjectSources_MediaObjectSourceTypes");
            });

            modelBuilder.Entity<MediaObjectSourceHost>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MediaObjectSourceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Modality>(entity =>
            {
                entity.HasIndex(e => e.IsActive)
                    .HasName("IDX_IsActive");

                entity.HasIndex(e => e.ModalityStatusId)
                    .HasName("IX_ModalityStatusId");

                entity.HasIndex(e => e.ModalityTypeId)
                    .HasName("IX_FK_ModalityModalityType");

                entity.HasIndex(e => new { e.Name, e.ModalityDescriptorId, e.ModalityTypeId })
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CourseNumber)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ModalityDescriptor)
                    .WithMany(p => p.Modalities)
                    .HasForeignKey(d => d.ModalityDescriptorId)
                    .HasConstraintName("FK_Modalities_ModalityDescriptors");

                entity.HasOne(d => d.ModalityStatus)
                    .WithMany(p => p.Modalities)
                    .HasForeignKey(d => d.ModalityStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Modalities_dbo.ModalityStatus_ModalityStatusId");

                entity.HasOne(d => d.ModalityType)
                    .WithMany(p => p.Modalities)
                    .HasForeignKey(d => d.ModalityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityModalityType");
            });

            modelBuilder.Entity<ModalityDescriptor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModalityStatu>(entity =>
            {
                entity.ToTable("ModalityStatus");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModalityType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModalityVariant>(entity =>
            {
                entity.HasIndex(e => e.IsActive)
                    .HasName("IDX_IsActive");

                entity.HasIndex(e => e.ModalityId)
                    .HasName("IX_FK_ModalityVariantModality");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name");

                entity.HasIndex(e => e.TakeAwayId)
                    .HasName("IX_FK_ModalityTakeAway");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CmeactivityCode)
                    .HasColumnName("CMEActivityCode")
                    .HasMaxLength(20);

                entity.Property(e => e.Cmecredits).HasColumnName("CMECredits");

                entity.Property(e => e.Cmeduration).HasColumnName("CMEDuration");

                entity.Property(e => e.CmeexpirationDate)
                    .HasColumnName("CMEExpirationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CustomIconPath).HasMaxLength(300);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.RevisionDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VariantExpirationDate).HasColumnType("datetime");

                entity.HasOne(d => d.Modality)
                    .WithMany(p => p.ModalityVariants)
                    .HasForeignKey(d => d.ModalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantModality");

                entity.HasOne(d => d.TakeAway)
                    .WithMany(p => p.ModalityVariants)
                    .HasForeignKey(d => d.TakeAwayId)
                    .HasConstraintName("FK_ModalityTakeAway");
            });

            modelBuilder.Entity<ModalityVariantCertification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Certification)
                    .WithMany(p => p.ModalityVariantCertifications)
                    .HasForeignKey(d => d.CertificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantCertifications_Certifications");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.ModalityVariantCertifications)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantCertifications_ModalityVariants");
            });

            modelBuilder.Entity<ModalityVariantCharacteristicValue>(entity =>
            {
                entity.HasKey(e => new { e.ModalityVariantId, e.CharacteristicValueId });

                entity.ToTable("ModalityVariantCharacteristicValue");

                entity.HasIndex(e => e.CharacteristicValueId)
                    .HasName("IX_CharacteristicValueId");

                entity.HasIndex(e => e.ModalityVariantId)
                    .HasName("IX_ModalityVariantId");

                entity.HasOne(d => d.CharacteristicValue)
                    .WithMany(p => p.ModalityVariantCharacteristicValues)
                    .HasForeignKey(d => d.CharacteristicValueId)
                    .HasConstraintName("FK_dbo.ModalityVariantCharacteristicValue_dbo.CharacteristicValues_CharacteristicValueId");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.ModalityVariantCharacteristicValues)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .HasConstraintName("FK_dbo.ModalityVariantCharacteristicValue_dbo.ModalityVariants_ModalityVariantId");
            });

            modelBuilder.Entity<ModalityVariantQuestionnaire>(entity =>
            {
                entity.HasIndex(e => e.ModalityVariantId)
                    .HasName("IX_FK_ModalityVariantQuestionnaireModalityVariant");

                entity.HasIndex(e => e.QuestionnaireId)
                    .HasName("IX_FK_ModalityVariantQuestionnaireQuestionnaire");

                entity.HasIndex(e => e.QuestionnaireUsageId)
                    .HasName("IX_FK_ModalityVariantQuestionnaireQuestionnaireUsage");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.ModalityVariantQuestionnaires)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantQuestionnaireModalityVariant");

                entity.HasOne(d => d.Questionnaire)
                    .WithMany(p => p.ModalityVariantQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantQuestionnaireQuestionnaire");

                entity.HasOne(d => d.QuestionnaireUsage)
                    .WithMany(p => p.ModalityVariantQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireUsageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantQuestionnaireQuestionnaireUsage");
            });

            modelBuilder.Entity<ModalityVariantRule>(entity =>
            {
                entity.HasIndex(e => e.ModalityVariantId)
                    .HasName("IDX_ModalityVariantId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Expression).IsRequired();

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.ModalityVariantRules)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModalityVariantRules_ModalityVariants");
            });

            modelBuilder.Entity<ModalityVariantsLiveEvent>(entity =>
            {
                entity.ToTable("ModalityVariants_LiveEvent");

                entity.HasIndex(e => e.MakeUpWebModuleId)
                    .HasName("IX_FK_LiveEventWebModule");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ModalityVariantsLiveEvent)
                    .HasForeignKey<ModalityVariantsLiveEvent>(d => d.Id)
                    .HasConstraintName("FK_LiveEvent_inherits_ModalityVariant");

                entity.HasOne(d => d.MakeUpWebModule)
                    .WithMany(p => p.ModalityVariantsLiveEvents)
                    .HasForeignKey(d => d.MakeUpWebModuleId)
                    .HasConstraintName("FK_LiveEventWebModule");
            });

            modelBuilder.Entity<ModalityVariantsRiskAlert>(entity =>
            {
                entity.ToTable("ModalityVariants_RiskAlert");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Explanation).IsRequired();

                entity.Property(e => e.ResponseOne)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ResponseThree).IsRequired();

                entity.Property(e => e.ResponseTwo).IsRequired();

                entity.Property(e => e.Scenario)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ModalityVariantsRiskAlert)
                    .HasForeignKey<ModalityVariantsRiskAlert>(d => d.Id)
                    .HasConstraintName("FK_RiskAlert_inherits_ModalityVariant");
            });

            modelBuilder.Entity<ModalityVariantState>(entity =>
            {
                entity.HasKey(e => new { e.ModalityVariantId, e.StateId });

                entity.ToTable("ModalityVariantState");

                entity.HasIndex(e => e.ModalityVariantId)
                    .HasName("IX_ModalityVariantId");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_StateId");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.ModalityVariantStates)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .HasConstraintName("FK_dbo.ModalityVariantState_dbo.ModalityVariants_ModalityVariantId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ModalityVariantStates)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_dbo.ModalityVariantState_dbo.States_StateId");
            });

            modelBuilder.Entity<ModalityVariantsTest>(entity =>
            {
                entity.ToTable("ModalityVariants_Test");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ModalityVariantsTest)
                    .HasForeignKey<ModalityVariantsTest>(d => d.Id)
                    .HasConstraintName("FK_Test_inherits_ModalityVariant");
            });

            modelBuilder.Entity<ModalityVariantsWebModule>(entity =>
            {
                entity.ToTable("ModalityVariants_WebModule");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ModalityVariantsWebModule)
                    .HasForeignKey<ModalityVariantsWebModule>(d => d.Id)
                    .HasConstraintName("FK_WebModule_inherits_ModalityVariant");

                entity.HasOne(d => d.MediaObject)
                    .WithMany(p => p.ModalityVariantsWebModules)
                    .HasForeignKey(d => d.MediaObjectId)
                    .HasConstraintName("FK_ModalityVariants_WebModule_MediaObjects");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasIndex(e => e.Description)
                    .HasName("IDX_Description_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasIndex(e => e.QuestionTypeId)
                    .HasName("IX_FK_QuestionQuestionType");

                entity.HasIndex(e => e.QuestionnaireVersionId)
                    .HasName("IX_FK_QuestionnaireVersionQuestion");

                entity.HasIndex(e => new { e.QuestionnaireVersionId, e.Sequence })
                    .HasName("IDX_QuestionnaireVersionID_Sequence");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.QuestionDisplayType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionDisplayTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questions_QuestionDisplayTypes");

                entity.HasOne(d => d.QuestionGroup)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionGroupId)
                    .HasConstraintName("FK_Questions_QuestionnaireVersionQuestionGroups");

                entity.HasOne(d => d.QuestionMeasure)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionMeasureId)
                    .HasConstraintName("FK_QuestionMeasure");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionQuestionType");

                entity.HasOne(d => d.QuestionnaireVersion)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionnaireVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionnaireVersionQuestion");
            });

            modelBuilder.Entity<QuestionAnswerCondition>(entity =>
            {
                entity.HasKey(e => new { e.QuestionId, e.AnswerId });

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.QuestionAnswerConditions)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAnswerConditions_Answers");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswerConditions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionAnswerConditions_Questions");
            });

            modelBuilder.Entity<QuestionDisplayType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.QuestionDisplayTypes)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionDisplayTypes_QuestionTypes");
            });

            modelBuilder.Entity<QuestionMeasure>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.QuestionnaireTypeId)
                    .HasName("IX_FK_QuestionnaireQuestionnaireType");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.QuestionnaireType)
                    .WithMany(p => p.Questionnaires)
                    .HasForeignKey(d => d.QuestionnaireTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionnaireQuestionnaireType");
            });

            modelBuilder.Entity<QuestionnaireState>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionnaireType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionnaireUsage>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionnaireVersion>(entity =>
            {
                entity.HasIndex(e => e.QuestionnaireId)
                    .HasName("IX_FK_QuestionnaireQuestionnaireVersion");

                entity.HasIndex(e => e.QuestionnaireStateId)
                    .HasName("IX_FK_QuestionnaireQuestionnaireState");

                entity.HasIndex(e => new { e.QuestionnaireId, e.Version })
                    .HasName("IDX_QuestionnaireID_Version")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.RetireDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Questionnaire)
                    .WithMany(p => p.QuestionnaireVersions)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionnaireQuestionnaireVersion");

                entity.HasOne(d => d.QuestionnaireState)
                    .WithMany(p => p.QuestionnaireVersions)
                    .HasForeignKey(d => d.QuestionnaireStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionnaireQuestionnaireState");
            });

            modelBuilder.Entity<QuestionnaireVersionQuestionGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuestionnaireVersion)
                    .WithMany(p => p.QuestionnaireVersionQuestionGroups)
                    .HasForeignKey(d => d.QuestionnaireVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionnaireVersionQuestionGroups_QuestionnaireVersions");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RiskAlertNotification>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ClientCurriculumPlanId);

                entity.HasIndex(e => e.CreationDate)
                    .HasName("CX_RiskAlertNotifications_CreationDate")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.RiskAlertId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.UserId, e.ClientCurriculumPlanId })
                    .HasName("IX_RiskAlertNotifications_Unique_UserId_ClientCurriculumPlanId")
                    .IsUnique();

                entity.HasIndex(e => new { e.RiskAlertId, e.UserId, e.ClientCurriculumPlanId })
                    .HasName("IX_RiskAlertNotifications_Unique_RiskAlertId_UserId_ClientCurriculumPlanId")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.RiskAlertNotifications)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientCurriculumPlanRiskAlertNotification");

                entity.HasOne(d => d.RiskAlert)
                    .WithMany(p => p.RiskAlertNotifications)
                    .HasForeignKey(d => d.RiskAlertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RiskAlertRiskAlertNotifications");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RiskAlertNotifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRiskAlertNotifications");
            });

            modelBuilder.Entity<SecurityRole>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.HasIndex(e => e.LastName)
                    .HasName("IDX_LastName");

                entity.HasIndex(e => e.SpeakerTypeId)
                    .HasName("IX_FK_SpeakerSpeakerType");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.Company })
                    .HasName("IDX_BusinessKey")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.SpeakerType)
                    .WithMany(p => p.Speakers)
                    .HasForeignKey(d => d.SpeakerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpeakerSpeakerType");
            });

            modelBuilder.Entity<SpeakerType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IDX_Code_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupportCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupportSource>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SupportTicket>(entity =>
            {
                entity.HasIndex(e => e.AssignedToUserId)
                    .HasName("IX_FK_SupportTicketAssignedToUser");

                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_SupportTicketClient");

                entity.HasIndex(e => e.DateClosed)
                    .HasName("IDX_DateClosed");

                entity.HasIndex(e => e.DateOpened)
                    .HasName("IDX_DateOpened");

                entity.HasIndex(e => e.Issue)
                    .HasName("IDX_Title");

                entity.HasIndex(e => e.RequestedByUserId)
                    .HasName("IX_FK_SupportTicketUser");

                entity.HasIndex(e => e.SupportCategoryId)
                    .HasName("IX_FK_SupportTicketSupportCategory");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateOpened).HasColumnType("datetime");

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AssignedToUser)
                    .WithMany(p => p.SupportTicketAssignedToUsers)
                    .HasForeignKey(d => d.AssignedToUserId)
                    .HasConstraintName("FK_SupportTicketAssignedToUser");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SupportTickets)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_SupportTicketClient");

                entity.HasOne(d => d.RequestedByUser)
                    .WithMany(p => p.SupportTicketRequestedByUsers)
                    .HasForeignKey(d => d.RequestedByUserId)
                    .HasConstraintName("FK_SupportTicketUser");

                entity.HasOne(d => d.SupportCategory)
                    .WithMany(p => p.SupportTickets)
                    .HasForeignKey(d => d.SupportCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportTicketSupportCategory");

                entity.HasOne(d => d.SupportSource)
                    .WithMany(p => p.SupportTickets)
                    .HasForeignKey(d => d.SupportSourceId)
                    .HasConstraintName("FK_SupportTicketSupportSource");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.SupportTickets)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_SupportTicketUserRoles");
            });

            modelBuilder.Entity<TakeAway>(entity =>
            {
                entity.HasIndex(e => e.IsActive)
                    .HasName("IDX_IsActive");

                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FileType).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TakeAways)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_TakeAwayFile");
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TenantClient>(entity =>
            {
                entity.HasKey(e => new { e.ClientsId, e.TenantsId });

                entity.ToTable("TenantClient");

                entity.HasIndex(e => e.ClientsId)
                    .HasName("IX_FK_TenantClient_Client");

                entity.Property(e => e.ClientsId).HasColumnName("Clients_Id");

                entity.Property(e => e.TenantsId).HasColumnName("Tenants_Id");

                entity.HasOne(d => d.Clients)
                    .WithMany(p => p.TenantClients)
                    .HasForeignKey(d => d.ClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantClient_Client");

                entity.HasOne(d => d.Tenants)
                    .WithMany(p => p.TenantClients)
                    .HasForeignKey(d => d.TenantsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantClient_Tenant");
            });

            modelBuilder.Entity<TimeZoneMap>(entity =>
            {
                entity.HasIndex(e => e.OlsonName)
                    .HasName("IDX_OlsonName");

                entity.HasIndex(e => e.WindowsName)
                    .HasName("IDX_WindowsName");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acronym)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OlsonName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WindowsName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.HasIndex(e => new { e.ToolCategoryId, e.Name })
                    .HasName("IDX_ToolCategoryId_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.Tools)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToolFile");

                entity.HasOne(d => d.ToolCategory)
                    .WithMany(p => p.Tools)
                    .HasForeignKey(d => d.ToolCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToolToolCategory");
            });

            modelBuilder.Entity<ToolCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IDX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.AccountDisabled)
                    .HasName("IDX_AccountDisabled");

                entity.HasIndex(e => e.EmailAddress)
                    .HasName("IDX_EmailAddress")
                    .IsUnique()
                    .HasFilter("([EmailAddress] IS NOT NULL)");

                entity.HasIndex(e => e.FirstName)
                    .HasName("IDX_FirstName");

                entity.HasIndex(e => e.LastName)
                    .HasName("IDX_LastName");

                entity.HasIndex(e => e.RegistrationCode)
                    .HasName("IDX_RegistrationCode_Unique")
                    .IsUnique();

                entity.HasIndex(e => e.ResetPasswordGuid)
                    .HasName("IDX_ResetPasswordGuid");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_FK_UserState");

                entity.HasIndex(e => e.TimeZoneId)
                    .HasName("IX_FK_UserTimeZone");

                entity.HasIndex(e => new { e.Latitude, e.Longitude })
                    .HasName("IDX_Latitude_Longitude");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountLockedTime).HasColumnType("datetime");

                entity.Property(e => e.AccountNumber).ValueGeneratedOnAdd();

                entity.Property(e => e.AdditionalCredentials).HasMaxLength(50);

                entity.Property(e => e.AdministrativeEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntroWatchedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordResetDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.Salt)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryEmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SendCurriculumAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendMissedEventAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendRiskAlerts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Street).HasMaxLength(200);

                entity.Property(e => e.Suite).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Zip).HasMaxLength(10);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_UserState");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TimeZoneId)
                    .HasConstraintName("FK_UserTimeZone");
            });

            modelBuilder.Entity<UserAnswer>(entity =>
            {
                entity.HasIndex(e => e.AnswerId)
                    .HasName("IX_FK_UserAnswerAnswer");

                entity.HasIndex(e => e.QuestionId)
                    .HasName("IX_FK_UserAnswerQuestion");

                entity.HasIndex(e => e.UserQuestionnaireId)
                    .HasName("IX_FK_UserQuestionnaireUserAnswer");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.UserAnswers)
                    .HasForeignKey(d => d.AnswerId)
                    .HasConstraintName("FK_UserAnswerAnswer");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.UserAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAnswerQuestion");

                entity.HasOne(d => d.UserQuestionnaire)
                    .WithMany(p => p.UserAnswers)
                    .HasForeignKey(d => d.UserQuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserQuestionnaireUserAnswer");
            });

            modelBuilder.Entity<UserCharacteristic>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_UserCharacteristics_Users");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CharacteristicCategory)
                    .WithMany(p => p.UserCharacteristics)
                    .HasForeignKey(d => d.CharacteristicCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCharacteristics_CharacteristicCategories");

                entity.HasOne(d => d.CharacteristicValue)
                    .WithMany(p => p.UserCharacteristics)
                    .HasForeignKey(d => d.CharacteristicValueId)
                    .HasConstraintName("FK_UserCharacteristics_CharacteristicValues");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCharacteristics)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCharacteristics_Users");
            });

            modelBuilder.Entity<UserClientCurriculumPlanModalitySubstitution>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.UserClientCurriculumPlanModalitySubstitutions)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClientCurriculumPlanModalitySubstitutions_ClientCurriculumPlans");

                entity.HasOne(d => d.Modality)
                    .WithMany(p => p.UserClientCurriculumPlanModalitySubstitutions)
                    .HasForeignKey(d => d.ModalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClientCurriculumPlanModalitySubstitutions_Modalities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClientCurriculumPlanModalitySubstitutions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClientCurriculumPlanModalitySubstitutions_Users");
            });

            modelBuilder.Entity<UserCompliance>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserCompliance)
                    .HasForeignKey<UserCompliance>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserComplianceUser");
            });

            modelBuilder.Entity<UserCredential>(entity =>
            {
                entity.HasKey(e => new { e.UsersId, e.CredentialsId });

                entity.ToTable("UserCredential");

                entity.HasIndex(e => e.CredentialsId)
                    .HasName("IX_FK_UserCredential_Credential");

                entity.Property(e => e.UsersId).HasColumnName("Users_Id");

                entity.Property(e => e.CredentialsId).HasColumnName("Credentials_Id");

                entity.HasOne(d => d.Credentials)
                    .WithMany(p => p.UserCredentials)
                    .HasForeignKey(d => d.CredentialsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCredential_Credential");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.UserCredentials)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCredential_User");
            });

            modelBuilder.Entity<UserCurriculum>(entity =>
            {
                entity.HasKey(e => new { e.RowNum, e.UserId })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ClientCurriculumId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.ContextDate)
                    .HasName("CX_UserCurriculums_ContextDate")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.EventRegistrationId);

                entity.HasIndex(e => e.IsPrerequisite)
                    .HasName("IDX_IsPrerequisite");

                entity.HasIndex(e => e.ModalityId);

                entity.HasIndex(e => e.ModalityTypeId);

                entity.HasIndex(e => e.ModalityVariantId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.UserModalityLogId);

                entity.HasIndex(e => new { e.StartDate, e.ProgramYearStartDate, e.ProgramYearEndDate })
                    .HasName("IDX_DateRanges");

                entity.HasIndex(e => new { e.UserId, e.ClientCurriculumId, e.UserRoleId })
                    .HasName("IX_UserCurriculums_UserRoleId");

                entity.HasIndex(e => new { e.ClientName, e.DepartmentName, e.LastName, e.FirstName })
                    .HasName("IDX_Names");

                entity.HasIndex(e => new { e.IsCurrentProgramYear, e.IsPastProgramYear, e.IsFutureProgramYear, e.IsTakeAnytime })
                    .HasName("IDX_ProgramYear");

                entity.Property(e => e.ClientCurriculumName).HasMaxLength(50);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ContextDate).HasColumnType("datetime");

                entity.Property(e => e.CurriculumTypeName).HasMaxLength(100);

                entity.Property(e => e.CustomIconPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EventEndTime).HasColumnType("datetime");

                entity.Property(e => e.EventStartTime).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GracePeriodDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModalityDescriptorName).HasMaxLength(50);

                entity.Property(e => e.ModalityName).HasMaxLength(200);

                entity.Property(e => e.ModalityState)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalityTypeName).HasMaxLength(50);

                entity.Property(e => e.ModalityVariantLastStep)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModalityVariantName).HasMaxLength(200);

                entity.Property(e => e.PreRegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.ProgramYearEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProgramYearStartDate).HasColumnType("datetime");

                entity.Property(e => e.RegisteredVariantName).HasMaxLength(200);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UsersEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.UsersEndingDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculum)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ClientCurriculumId)
                    .HasConstraintName("FK_UserCurriculumClientCurriculum");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .HasConstraintName("FK_UserCurriculumClientCurriculumPlan");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCurriculumClient");

                entity.HasOne(d => d.CurriculumType)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.CurriculumTypeId)
                    .HasConstraintName("FK_UserCurriculumCurriculumType");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_UserCurriculumDepartment");

                entity.HasOne(d => d.EventRegistration)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.EventRegistrationId)
                    .HasConstraintName("FK_UserCurriculumsEventRegistrations");

                entity.HasOne(d => d.ModalityDescriptor)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ModalityDescriptorId)
                    .HasConstraintName("FK_UserCurriculums_ModalityDescriptors");

                entity.HasOne(d => d.Modality)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ModalityId)
                    .HasConstraintName("FK_UserCurriculumModality");

                entity.HasOne(d => d.ModalityType)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.ModalityTypeId)
                    .HasConstraintName("FK_UserCurriculumModalityType");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.UserCurriculumModalityVariants)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .HasConstraintName("FK_UserCurriculumModalityVariant");

                entity.HasOne(d => d.SubstitutedModalityVariant)
                    .WithMany(p => p.UserCurriculumSubstitutedModalityVariants)
                    .HasForeignKey(d => d.SubstitutedModalityVariantId)
                    .HasConstraintName("FK_UserCurriculumSubstituteModalityVariant");

                entity.HasOne(d => d.UserClientCurriculumPlanModalitySubstitution)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.UserClientCurriculumPlanModalitySubstitutionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_UserCurriculums_UserClientCurriculumPlanModalitySubstitutions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCurriculumUser");

                entity.HasOne(d => d.UserModalityLog)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.UserModalityLogId)
                    .HasConstraintName("FK_UserCurriculumsUserModalityLogs");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserCurriculums)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_UserCurriculumUserRole");
            });

            modelBuilder.Entity<UserCustomField>(entity =>
            {
                entity.HasIndex(e => e.ClientCustomFieldId)
                    .HasName("IX_ClientCustomFieldId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CustomFieldText).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCustomField)
                    .WithMany(p => p.UserCustomFields)
                    .HasForeignKey(d => d.ClientCustomFieldId)
                    .HasConstraintName("FK_dbo.UserCustomFields_dbo.ClientCustomFields_ClientCustomFieldId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCustomFields)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.UserCustomFields_dbo.Users_UserId");
            });

            modelBuilder.Entity<UserModalityLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.ClientCurriculumPlanId);

                entity.HasIndex(e => e.EventRegistrationId);

                entity.HasIndex(e => e.ModalityVariantId);

                entity.HasIndex(e => e.StartedTime)
                    .HasName("CX_UserModalityLogs_StartedTime")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.SubstitutedModalityVariantId);

                entity.HasIndex(e => e.TimeZoneMapId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.UserId, e.ModalityVariantId, e.EndedTime })
                    .HasName("IDX_UserId_ModalityId_EndedTime");

                entity.HasIndex(e => new { e.UserId, e.ModalityVariantId, e.StartedTime })
                    .HasName("IDX_UserId_ModalityId_StartedTime_Unique")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserId, e.ClientCurriculumPlanId, e.ModalityVariantId, e.EventRegistrationId })
                    .HasName("IDX_UserId_ClientCurriculumPlanId_ModalityVariantId_EventRegistrationId_Unique")
                    .IsUnique()
                    .HasFilter("([ClientCurriculumPlanId] IS NOT NULL)");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdditionalStepInfo).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndedTime).HasColumnType("datetime");

                entity.Property(e => e.LastStep).HasMaxLength(30);

                entity.Property(e => e.StartedTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculumPlan)
                    .WithMany(p => p.UserModalityLogs)
                    .HasForeignKey(d => d.ClientCurriculumPlanId)
                    .HasConstraintName("FK_UserModalityLogClientCurriculumPlan");

                entity.HasOne(d => d.EventRegistration)
                    .WithMany(p => p.UserModalityLogs)
                    .HasForeignKey(d => d.EventRegistrationId)
                    .HasConstraintName("FK_UserModalityLogRegistration");

                entity.HasOne(d => d.ModalityVariant)
                    .WithMany(p => p.UserModalityLogModalityVariants)
                    .HasForeignKey(d => d.ModalityVariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModalityLogModality");

                entity.HasOne(d => d.SubstitutedModalityVariant)
                    .WithMany(p => p.UserModalityLogSubstitutedModalityVariants)
                    .HasForeignKey(d => d.SubstitutedModalityVariantId)
                    .HasConstraintName("FK_UserModalityLogModalityVariant");

                entity.HasOne(d => d.TimeZoneMap)
                    .WithMany(p => p.UserModalityLogs)
                    .HasForeignKey(d => d.TimeZoneMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModalityLogTimeZoneMap");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserModalityLogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModalityLogUser");
            });

            modelBuilder.Entity<UserQuestionnaire>(entity =>
            {
                entity.HasIndex(e => e.QuestionnaireUsageId)
                    .HasName("IX_FK_UserQuestionnaireQuestionnaireUsage");

                entity.HasIndex(e => e.QuestionnaireVersionId)
                    .HasName("IX_FK_UserQuestionnaireQuestionnaireVersion");

                entity.HasIndex(e => e.UserModalityLogId)
                    .HasName("IX_FK_UserModalityLogUserQuestionnaire");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TakenDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.QuestionnaireUsage)
                    .WithMany(p => p.UserQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireUsageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserQuestionnaireQuestionnaireUsage");

                entity.HasOne(d => d.QuestionnaireVersion)
                    .WithMany(p => p.UserQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserQuestionnaireQuestionnaireVersion");

                entity.HasOne(d => d.UserModalityLog)
                    .WithMany(p => p.UserQuestionnaires)
                    .HasForeignKey(d => d.UserModalityLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserModalityLogUserQuestionnaire");

                entity.HasOne(d => d.UserQuestionnaireStatusType)
                    .WithMany(p => p.UserQuestionnaires)
                    .HasForeignKey(d => d.UserQuestionnaireStatusTypeId)
                    .HasConstraintName("FK_UserQuestionnairesUserQuestionnairesStatusTypes");
            });

            modelBuilder.Entity<UserQuestionnaireStatusType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_UserRoleClient");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_FK_UserRoleDepartment");

                entity.HasIndex(e => e.SecurityRoleId)
                    .HasName("IX_FK_UserRoleSecurityRole");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_UserUserRole");

                entity.HasIndex(e => new { e.UserId, e.ClientId, e.SecurityRoleId })
                    .HasName("UserRoles_Client_Role_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalSystemId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleClient");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_UserRoleDepartment");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleSecurityRole");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUserRole");
            });

            modelBuilder.Entity<UserRoleCharacteristic>(entity =>
            {
                entity.HasIndex(e => e.UserRoleId)
                    .HasName("IX_FK_UserRoleCharacteristics_UserRoles");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CharacteristicCategory)
                    .WithMany(p => p.UserRoleCharacteristics)
                    .HasForeignKey(d => d.CharacteristicCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleCharacteristics_CharacteristicCategories");

                entity.HasOne(d => d.CharacteristicValue)
                    .WithMany(p => p.UserRoleCharacteristics)
                    .HasForeignKey(d => d.CharacteristicValueId)
                    .HasConstraintName("FK_UserRoleCharacteristics_CharacteristicValues");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.UserRoleCharacteristics)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleCharacteristics_UserRoles");
            });

            modelBuilder.Entity<UserRoleCompliance>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.HasIndex(e => e.ClientCurriculumId)
                    .HasName("IX_FK_UserComplianceClientCurriculum");

                entity.Property(e => e.UserRoleId).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClientCurriculum)
                    .WithMany(p => p.UserRoleCompliances)
                    .HasForeignKey(d => d.ClientCurriculumId)
                    .HasConstraintName("FK_UserComplianceClientCurriculum");

                entity.HasOne(d => d.UserRole)
                    .WithOne(p => p.UserRoleCompliance)
                    .HasForeignKey<UserRoleCompliance>(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserComplianceUserRole");
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_FK_VenueClient");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_FK_VenueState");

                entity.HasIndex(e => e.TimeZoneId)
                    .HasName("IX_FK_VenueTimeZone");

                entity.HasIndex(e => new { e.Latitude, e.Longitude })
                    .HasName("IDX_Latitude_Longitude");

                entity.HasIndex(e => new { e.Location, e.Building, e.Room })
                    .HasName("IDX_Location_Building_Room_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Building)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DirectionsToRoom).IsRequired();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Notes).IsRequired();

                entity.Property(e => e.Phone).HasMaxLength(100);

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Venues)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_VenueClient");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Venues)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VenueState");

                entity.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Venues)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VenueTimeZone");
            });

            modelBuilder.Entity<Webinar>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Hlspath)
                    .HasColumnName("HLSPath")
                    .HasMaxLength(2048);

                entity.Property(e => e.Hmackey)
                    .HasColumnName("HMACKey")
                    .HasMaxLength(32);

                entity.Property(e => e.LiveStreamId).HasMaxLength(20);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Chatroom)
                    .WithMany(p => p.Webinars)
                    .HasForeignKey(d => d.ChatroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Webinars_Chatrooms");

                entity.HasOne(d => d.RecordedMediaObject)
                    .WithMany(p => p.Webinars)
                    .HasForeignKey(d => d.RecordedMediaObjectId)
                    .HasConstraintName("FK_Webinars_RecordedMediaObjects");
            });

            modelBuilder.Entity<WebModuleSpeaker>(entity =>
            {
                entity.HasKey(e => new { e.WebModulesId, e.SpeakersId });

                entity.ToTable("WebModuleSpeaker");

                entity.HasIndex(e => e.SpeakersId)
                    .HasName("IX_FK_WebModuleSpeaker_Speaker");

                entity.Property(e => e.WebModulesId).HasColumnName("WebModules_Id");

                entity.Property(e => e.SpeakersId).HasColumnName("Speakers_Id");

                entity.HasOne(d => d.Speakers)
                    .WithMany(p => p.WebModuleSpeakers)
                    .HasForeignKey(d => d.SpeakersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebModuleSpeaker_Speaker");

                entity.HasOne(d => d.WebModules)
                    .WithMany(p => p.WebModuleSpeakers)
                    .HasForeignKey(d => d.WebModulesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebModuleSpeaker_WebModule");
            });
        }
    }
}
