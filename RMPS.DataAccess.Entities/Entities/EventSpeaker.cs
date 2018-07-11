using System;

namespace RMPS.DataAccess.Entities
{
    public partial class EventSpeaker
    {
        public Guid EventsId { get; set; }
        public Guid SpeakersId { get; set; }

        public EventSession Events { get; set; }
        public Speaker Speakers { get; set; }
    }
}
