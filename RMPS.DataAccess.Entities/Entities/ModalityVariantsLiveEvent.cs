using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantsLiveEvent
    {
        public ModalityVariantsLiveEvent()
        {
            EventSessions = new HashSet<EventSession>();
        }

        public int TypicalDurationMinutes { get; set; }
        public Guid Id { get; set; }
        public Guid? MakeUpWebModuleId { get; set; }

        public ModalityVariant IdNavigation { get; set; }
        public ModalityVariantsWebModule MakeUpWebModule { get; set; }
        public ICollection<EventSession> EventSessions { get; set; }
    }
}
