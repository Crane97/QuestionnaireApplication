using QuestionnaireApplication.models;

namespace QuestionnaireApplication.repositories.Implementation
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { }
    }
}
