using Microsoft.AspNetCore.Mvc;
using QuestionnaireApplication.models;
using QuestionnaireApplication.repositories;
using QuestionnaireApplication.services;
using QuestionnaireApplication.services.interfaces;

namespace QuestionnaireApplication.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService service;

        public QuestionController(IQuestionService service)
        {
            this.service = service;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet(Name = "GetQuestions")]
        public IEnumerable<Question> Get()
        {
            return service.Get();
        }

        [HttpPost(Name = "add")]
        public Question Post(Question question)
        {
            return service.PostQuestion(question);
        }
    }
}
