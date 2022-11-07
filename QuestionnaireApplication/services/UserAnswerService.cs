using QuestionnaireApplication.models;
using QuestionnaireApplication.repositories;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.services
{
    public class UserAnswerService : IUserAnswerService
    {
        public RepositoryContext repository;

        public UserAnswerService(RepositoryContext repository)
        {
            this.repository = repository;
        }

        public IEnumerable<UserAnswer> Get()
        {
            return repository.UserAnswers.ToList();
        }

        public UserAnswer AddUserAnswer(UserAnswer userAnswer)
        {
            repository.UserAnswers.Add(userAnswer);
            repository.SaveChanges();
            return userAnswer;
        }
    }
}
