using Microsoft.EntityFrameworkCore;
using QuestionnaireApplication.models;

namespace QuestionnaireApplication.repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }

        public DbSet<Question>? Questions { get; set; }
        public DbSet<Answer>? Answers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnswer>? UserAnswers { get; set; }
    }
}
