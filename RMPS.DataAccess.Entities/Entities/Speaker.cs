using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Speaker
    {
        public Speaker()
        {
            EventSpeakers = new HashSet<EventSpeaker>();
            WebModuleSpeakers = new HashSet<WebModuleSpeaker>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public string Company { get; set; }
        public Guid ChangedById { get; set; }
        public Guid Id { get; set; }
        public Guid SpeakerTypeId { get; set; }

        public SpeakerType SpeakerType { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
        public ICollection<WebModuleSpeaker> WebModuleSpeakers { get; set; }
    }
}
