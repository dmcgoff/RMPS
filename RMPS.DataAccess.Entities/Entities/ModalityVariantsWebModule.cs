using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantsWebModule
    {
        public ModalityVariantsWebModule()
        {
            ModalityVariantsLiveEvents = new HashSet<ModalityVariantsLiveEvent>();
            WebModuleSpeakers = new HashSet<WebModuleSpeaker>();
        }

        public int DurationMinutes { get; set; }
        public string AdditionalInformation { get; set; }
        public Guid Id { get; set; }
        public Guid? MediaObjectId { get; set; }

        public ModalityVariant IdNavigation { get; set; }
        public MediaObject MediaObject { get; set; }
        public ICollection<ModalityVariantsLiveEvent> ModalityVariantsLiveEvents { get; set; }
        public ICollection<WebModuleSpeaker> WebModuleSpeakers { get; set; }
    }
}
