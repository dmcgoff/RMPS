using System;
using System.Collections.Generic;

namespace RMPS.DataAccess.Entities
{
    public partial class TimeZoneMap
    {
        public TimeZoneMap()
        {
            UserModalityLogs = new HashSet<UserModalityLog>();
            Users = new HashSet<User>();
            Venues = new HashSet<Venue>();
        }

        public string OlsonName { get; set; }
        public string WindowsName { get; set; }
        public string Country { get; set; }
        public string RuleName { get; set; }
        public int GmtOffsetSeconds { get; set; }
        public string Acronym { get; set; }
        public Guid Id { get; set; }

        public ICollection<UserModalityLog> UserModalityLogs { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Venue> Venues { get; set; }
    }
}
