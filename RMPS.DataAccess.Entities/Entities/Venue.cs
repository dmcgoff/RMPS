using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class Venue
    {
        public Venue()
        {
            EventSessionAudienceVenues = new HashSet<EventSession>();
            EventSessionSpeakerVenues = new HashSet<EventSession>();
        }

        public string Location { get; set; }
        public string Building { get; set; }
        public string Room { get; set; }
        public int? Capacity { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool LaptopRequired { get; set; }
        public bool ProjectorRequired { get; set; }
        public bool ExtensionCordRequired { get; set; }
        public bool ComputerLogInInfoRequired { get; set; }
        public bool RoomAccessAssistanceRequired { get; set; }
        public bool SupportsVideoconferencing { get; set; }
        public string DirectionsToRoom { get; set; }
        public string Notes { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? ClientId { get; set; }
        public Guid StateId { get; set; }
        public Guid TimeZoneId { get; set; }
        public Guid Id { get; set; }

        public Client Client { get; set; }
        public State State { get; set; }
        public TimeZoneMap TimeZone { get; set; }
        public ICollection<EventSession> EventSessionAudienceVenues { get; set; }
        public ICollection<EventSession> EventSessionSpeakerVenues { get; set; }
    }
}
