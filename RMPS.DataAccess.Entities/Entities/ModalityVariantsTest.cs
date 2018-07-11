using System;

namespace RMPS.DataAccess.Entities
{
    public partial class ModalityVariantsTest
    {
        public Guid Id { get; set; }

        public ModalityVariant IdNavigation { get; set; }
    }
}
