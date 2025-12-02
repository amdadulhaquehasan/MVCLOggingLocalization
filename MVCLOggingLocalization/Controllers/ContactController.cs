using Microsoft.AspNetCore.Mvc;
using MVCLOggingLocalization.Models;

namespace MVCLOggingLocalization.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View(new ContactFromModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactFromModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Thank you for your message. We will get back to you shortly.";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}