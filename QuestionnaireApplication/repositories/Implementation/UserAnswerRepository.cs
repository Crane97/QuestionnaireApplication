using QuestionnaireApplication.models;

namespace QuestionnaireApplication.repositories.Implementation
{
    public class UserAnswerRepository : RepositoryBase<UserAnswer>, IUserAnswerRepository
    {
        public UserAnswerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { }
    }
}
