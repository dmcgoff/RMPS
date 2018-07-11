using System;

namespace RMPS.DataAccess.Entities
{
    public partial class LogsUserLogin
    {
        public DateTime LoginTime { get; set; }
        public DateTime CreationDate { get; set; }
        public string BrowserType { get; set; }
        public string BrowserVersion { get; set; }
        public string BrowserPlatform { get; set; }
        public string BrowserUserAgent { get; set; }
        public string BrowserIpaddress { get; set; }
        public Guid UserId { get; set; }
        public Guid Id { get; set; }

        public User User { get; set; }
    }
}
