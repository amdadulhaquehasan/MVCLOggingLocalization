using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLOggingLocalization.Models;

namespace MVCLOggingLocalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Information: Landing to home index view");
            _logger.LogWarning("Warning: Landing to home index view");
            _logger.LogError("Error: Landing to home index view");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
