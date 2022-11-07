using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("useranswer")]
    public class UserAnswer
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
    }
}
