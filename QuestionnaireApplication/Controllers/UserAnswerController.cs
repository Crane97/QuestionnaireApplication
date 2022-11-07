using Microsoft.AspNetCore.Mvc;
using QuestionnaireApplication.models;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserAnswerController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        private readonly IUserAnswerService service;

        public UserAnswerController(IUserAnswerService service)
        {
            this.service = service;
        }

        [HttpGet(Name = "GetUserAnswers")]
        public IEnumerable<UserAnswer> Get()
        {
            return service.Get();
        }

        [HttpPost(Name = "addUserAnswer")]
        public UserAnswer Post(UserAnswer userAnswer)
        {
            return service.AddUserAnswer(userAnswer);
        }
    }
}
