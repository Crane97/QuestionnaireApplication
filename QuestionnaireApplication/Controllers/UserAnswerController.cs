using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireApplication.Controllers
{
    public class UserAnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
