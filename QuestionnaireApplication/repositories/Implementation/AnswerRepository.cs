using QuestionnaireApplication.models;

namespace QuestionnaireApplication.repositories.Implementation
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public AnswerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        { }
    }
}
