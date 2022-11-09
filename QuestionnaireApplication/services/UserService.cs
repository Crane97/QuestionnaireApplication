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
            Boolean flag = true;
            if (user.Email != null && user.Email != "" )
            {
                List<User> users = repository.Users.ToList();

                foreach (var user1 in users)
                {
                    if(user1.Email == user.Email)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    repository.Add(user);
                    repository.SaveChanges();
                    return user;
                }
            }
            return null;
        }
    }
}
