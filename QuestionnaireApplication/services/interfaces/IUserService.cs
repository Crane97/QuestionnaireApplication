using QuestionnaireApplication.models;

namespace QuestionnaireApplication.services.interfaces
{
    public interface IUserService
    {

        public IEnumerable<User> Get();

        public User PostUser(User user);
    }
}
