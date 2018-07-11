using System;

namespace RMPS.DataAccess.Entities
{
    public partial class QuestionAnswerCondition
    {
        public Guid QuestionId { get; set; }
        public Guid AnswerId { get; set; }

        public Answer Answer { get; set; }
        public Question Question { get; set; }
    }
}
