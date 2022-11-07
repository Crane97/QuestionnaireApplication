using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionnaireApplication.models
{
    [Table("user")]
    public class User
    {
        public User() { }

        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
