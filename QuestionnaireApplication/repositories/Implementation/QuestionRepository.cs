using QuestionnaireApplication.models;

namespace QuestionnaireApplication.repositories.Implementation
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        { }

    }
}
