using QuestionnaireApplication.models;
using QuestionnaireApplication.repositories;
using QuestionnaireApplication.repositories.Implementation;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.services
{
    public class QuestionService : IQuestionService
    {
        public RepositoryContext repository;

        public QuestionService(RepositoryContext repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Question> Get()
        {
            return repository.Questions.ToList();
        }

        public Question PostQuestion(Question question)
        {
            repository.Questions.Add(question);
            foreach (Answer answer in question.AnswerText)
            {
                repository.Answers.Add(answer);
            }
            repository.SaveChanges();
            return question;
        }

    }
}
