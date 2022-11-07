using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("question")]
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public ICollection<Answer> AnswerText { get; set; }

    }
}
