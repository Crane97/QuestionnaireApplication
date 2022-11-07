using Microsoft.AspNetCore.Mvc;

namespace QuestionnaireApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
