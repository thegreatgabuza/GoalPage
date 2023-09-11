using Microsoft.AspNetCore.Mvc;

namespace GoalPage.Controllers
{
    public class MyGoalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
