using System;

namespace RMPS.DataAccess.Entities
{
    public partial class WebModuleSpeaker
    {
        public Guid SpeakersId { get; set; }
        public Guid WebModulesId { get; set; }

        public Speaker Speakers { get; set; }
        public ModalityVariantsWebModule WebModules { get; set; }
    }
}
