using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ElmDataMapping
    {
        public Guid Id { get; set; }
        public Guid ArksValueId { get; set; }
        public string ArksValue { get; set; }
        public string ElmValue { get; set; }
        public string ElmMappingType { get; set; }
    }
}
