using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class EventSession
    {
        public EventSession()
        {
            EventRegistrations = new HashSet<EventRegistration>();
            EventSessionCertifications = new HashSet<EventSessionCertification>();
            EventSessionClients = new HashSet<EventSessionClient>();
            EventSpeakers = new HashSet<EventSpeaker>();
        }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? Capacity { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public string AudienceInstructions { get; set; }
        public Guid Guid { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid EventSessionTypeId { get; set; }
        public Guid? AudienceVenueId { get; set; }
        public Guid? SpeakerVenueId { get; set; }
        public Guid LiveEventId { get; set; }
        public Guid? MediaObjectId { get; set; }
        public Guid? WebinarId { get; set; }
        public bool UseExternalQuestionnaires { get; set; }

        public Venue AudienceVenue { get; set; }
        public EventSessionType EventSessionType { get; set; }
        public ModalityVariantsLiveEvent LiveEvent { get; set; }
        public MediaObject MediaObject { get; set; }
        public Venue SpeakerVenue { get; set; }
        public Webinar Webinar { get; set; }
        public ICollection<EventRegistration> EventRegistrations { get; set; }
        public ICollection<EventSessionCertification> EventSessionCertifications { get; set; }
        public ICollection<EventSessionClient> EventSessionClients { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
