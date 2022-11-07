using QuestionnaireApplication.models;

namespace QuestionnaireApplication.services.interfaces
{
    public interface IQuestionService
    {
        public IEnumerable<Question> Get();

        public Question PostQuestion(Question question);
    }
}
