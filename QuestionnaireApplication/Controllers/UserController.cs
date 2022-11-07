using Microsoft.AspNetCore.Mvc;
using QuestionnaireApplication.models;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }
        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return service.Get();
        }

        [HttpPost(Name = "addUser")]
        public User Post(User question)
        {
            return service.PostUser(question);
        }
    }
}
