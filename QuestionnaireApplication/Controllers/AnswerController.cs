using Microsoft.AspNetCore.Mvc;
using QuestionnaireApplication.models;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService service;

        public AnswerController(IAnswerService service)
        {
            this.service = service;
        }

        [HttpGet(Name ="GetAnswers")]
        public IEnumerable<Answer> Get()
        {
            return service.GetAnswers();
        }

        [HttpPost(Name = "addAnswer")]
        public Answer AddAnswer(Answer answer)
        {
            return service.AddAnswer(answer);
        }

        /*public IActionResult Index()
        {
            return View();
        }*/


    }
}
