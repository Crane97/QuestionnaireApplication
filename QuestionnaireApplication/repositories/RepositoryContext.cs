using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using QuestionnaireApplication.models;
using System.Reflection.Metadata;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAnswer>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<UserAnswer>()
                .HasOne<Question>()
                .WithMany()
                .HasForeignKey(p => p.QuestionId);
        }
    }
}
