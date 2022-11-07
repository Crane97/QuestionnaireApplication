using QuestionnaireApplication.models;
using QuestionnaireApplication.repositories;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.services
{
    public class AnswerService : IAnswerService
    {

        public RepositoryContext repository;

        public AnswerService(RepositoryContext repository)
        {
            this.repository = repository;
        }

        public Answer AddAnswer(Answer answer)
        {
            repository.Add(answer);
            repository.SaveChanges();
            return answer;
        }

        public IEnumerable<Answer> GetAnswers()
        {
            return repository.Answers.ToList();
        }
    }
}
