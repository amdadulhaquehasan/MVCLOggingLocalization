using Microsoft.AspNetCore.Mvc;

namespace MVCLOggingLocalization.Controllers
{
    public class TagHelpersController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuiltIn()
        {
            return View();
        }

        public IActionResult Custom()
        {
            return View();
        }
    }
}
