using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("question")]
    public class Question
    {
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public ICollection<Answer> AnswerText { get; set; }

    }
}
