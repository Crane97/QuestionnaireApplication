using QuestionnaireApplication.models;

namespace QuestionnaireApplication.services.interfaces
{
    public interface IUserAnswerService
    {
        public IEnumerable<UserAnswer> Get();

        public UserAnswer AddUserAnswer(UserAnswer userAnswer);

    }
}
