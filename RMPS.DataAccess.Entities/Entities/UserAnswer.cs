using System;

namespace RMPS.DataAccess.Entities
{
    public partial class UserAnswer
    {
        public bool? WasCorrect { get; set; }
        public string AnswerText { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid ChangedById { get; set; }
        public Guid? AnswerId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid Id { get; set; }
        public Guid UserQuestionnaireId { get; set; }

        public Answer Answer { get; set; }
        public Question Question { get; set; }
        public UserQuestionnaire UserQuestionnaire { get; set; }
    }
}
