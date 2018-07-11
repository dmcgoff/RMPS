using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class MediaObject
    {
        public MediaObject()
        {
            EventSessions = new HashSet<EventSession>();
            IntroVideos = new HashSet<IntroVideo>();
            ModalityVariantsWebModules = new HashSet<ModalityVariantsWebModule>();
            Webinars = new HashSet<Webinar>();
        }

        public Guid Id { get; set; }
        public Guid MediaObjectSourceId { get; set; }
        public string Path { get; set; }
        public string PlaceholderImagePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }

        public MediaObjectSource MediaObjectSource { get; set; }
        public ICollection<EventSession> EventSessions { get; set; }
        public ICollection<IntroVideo> IntroVideos { get; set; }
        public ICollection<ModalityVariantsWebModule> ModalityVariantsWebModules { get; set; }
        public ICollection<Webinar> Webinars { get; set; }
    }
}
