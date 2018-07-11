using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariant
    {
        public ModalityVariant()
        {
            ModalityVariantCertifications = new HashSet<ModalityVariantCertification>();
            ModalityVariantCharacteristicValues = new HashSet<ModalityVariantCharacteristicValue>();
            ModalityVariantQuestionnaires = new HashSet<ModalityVariantQuestionnaire>();
            ModalityVariantRules = new HashSet<ModalityVariantRule>();
            ModalityVariantStates = new HashSet<ModalityVariantState>();
            UserCurriculumModalityVariants = new HashSet<UserCurriculum>();
            UserCurriculumSubstitutedModalityVariants = new HashSet<UserCurriculum>();
            UserModalityLogModalityVariants = new HashSet<UserModalityLog>();
            UserModalityLogSubstitutedModalityVariants = new HashSet<UserModalityLog>();
        }

        public string Name { get; set; }
        public double? Cmecredits { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? RevisionDate { get; set; }
        public DateTime? CmeexpirationDate { get; set; }
        public int? Cmeduration { get; set; }
        public string Objectives { get; set; }
        public string CustomIconPath { get; set; }
        public string CmeactivityCode { get; set; }
        public string PrivateNote { get; set; }
        public Guid ChangedById { get; set; }
        public string TargetAudience { get; set; }
        public string ConsistsOf { get; set; }
        public string Details { get; set; }
        public string AccreditationInfo { get; set; }
        public string ConflictOfInterestPolicy { get; set; }
        public string Contacts { get; set; }
        public string Disclosure { get; set; }
        public string Bibliography { get; set; }
        public Guid ModalityId { get; set; }
        public Guid? TakeAwayId { get; set; }
        public Guid Id { get; set; }
        public bool IsInstructionsVisible { get; set; }
        public bool IsDisclosureVisible { get; set; }
        public string Copyright { get; set; }
        public string Disclaimer { get; set; }
        public string Funding { get; set; }
        public DateTime? VariantExpirationDate { get; set; }
        public Guid StatusId { get; set; }
        public string CaseDatabaseReferenceNumbers { get; set; }

        public Modality Modality { get; set; }
        public TakeAway TakeAway { get; set; }
        public ModalityVariantsLiveEvent ModalityVariantsLiveEvent { get; set; }
        public ModalityVariantsRiskAlert ModalityVariantsRiskAlert { get; set; }
        public ModalityVariantsTest ModalityVariantsTest { get; set; }
        public ModalityVariantsWebModule ModalityVariantsWebModule { get; set; }
        public ICollection<ModalityVariantCertification> ModalityVariantCertifications { get; set; }
        public ICollection<ModalityVariantCharacteristicValue> ModalityVariantCharacteristicValues { get; set; }
        public ICollection<ModalityVariantQuestionnaire> ModalityVariantQuestionnaires { get; set; }
        public ICollection<ModalityVariantRule> ModalityVariantRules { get; set; }
        public ICollection<ModalityVariantState> ModalityVariantStates { get; set; }
        public ICollection<UserCurriculum> UserCurriculumModalityVariants { get; set; }
        public ICollection<UserCurriculum> UserCurriculumSubstitutedModalityVariants { get; set; }
        public ICollection<UserModalityLog> UserModalityLogModalityVariants { get; set; }
        public ICollection<UserModalityLog> UserModalityLogSubstitutedModalityVariants { get; set; }
    }
}
