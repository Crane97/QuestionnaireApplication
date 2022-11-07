using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("answer")]
    public class Answer
    {
        public int Id { get; set; }

        //public Question Question { get; set; }

        public string Option { get; set; }
    }
}
