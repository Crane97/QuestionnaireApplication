using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireApplication.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
