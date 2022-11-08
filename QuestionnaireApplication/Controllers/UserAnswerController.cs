using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QuestionnaireApplication.models;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [EnableCors]
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
        [EnableCors]
        public IEnumerable<UserAnswer> Get()
        {
            return service.Get();
        }

        [HttpPost(Name = "addUserAnswer")]
        [EnableCors]
        public UserAnswer Post(UserAnswer userAnswer)
        {
            return service.AddUserAnswer(userAnswer);
        }
    }
}
