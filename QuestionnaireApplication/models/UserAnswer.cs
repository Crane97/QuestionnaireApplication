using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("useranswer")]
    public class UserAnswer
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Question Question { get; set; }
        public string Answer { get; set; }
    }
}
