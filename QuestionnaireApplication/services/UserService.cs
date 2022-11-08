using QuestionnaireApplication.models;
using QuestionnaireApplication.repositories;
using QuestionnaireApplication.repositories.Implementation;

namespace QuestionnaireApplication.services
{
    public class UserService : interfaces.IUserService
    {
        public RepositoryContext repository;

        public UserService(RepositoryContext repository)
        {
            this.repository = repository;
        }

        public IEnumerable<User> Get()
        {
            return repository.Users.ToList();
        }

        public User PostUser(User user)
        {
            if (user.Email != null && user.Email != "")
            {
                repository.Add(user);
                repository.SaveChanges();
                return user;
            }
            return null;
        }
    }
}
