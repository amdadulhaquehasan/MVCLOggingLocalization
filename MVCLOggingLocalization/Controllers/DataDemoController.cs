using Microsoft.AspNetCore.Mvc;

namespace MVCLOggingLocalization.Controllers
{
    public class DataDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Data Demo";
            ViewData["Message"] = "This message is passed using ViewData.";
            ViewData["CurrentTime"] = DateTime.Now;
            ViewData["Numbers"] = new List<int> { 1, 2, 3, 4, 5 };

            ViewBag.WelcomeMessage = "Welcome to ViewBag demo!";
            ViewBag.User = new { Name = "Hasan", Email = "Hasan11@gmail.com" };
            ViewBag.Colors = new[] { "Red", "Green", "Blue", "Yellow" };

            return View();
        }

        public IActionResult FirstPage()
        {
            TempData["Message"] = "This Message was set on FirstPage and will be available on SecondPahe";
            TempData["TimeStamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            return RedirectToAction("SecondPage");
        }

        public IActionResult SecondPage()
        {
            return View();
        }

        public IActionResult Localization()
        {
            return View();
        }
    }
}
