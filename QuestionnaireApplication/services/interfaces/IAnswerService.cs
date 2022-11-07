using QuestionnaireApplication.models;

namespace QuestionnaireApplication.services.interfaces
{
    public interface IAnswerService
    {
        public IEnumerable<Answer> GetAnswers();

        public Answer AddAnswer(Answer answer);
    }
}
