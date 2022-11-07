using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("answer")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        //public Question Question { get; set; }

        public string Option { get; set; }
    }
}
