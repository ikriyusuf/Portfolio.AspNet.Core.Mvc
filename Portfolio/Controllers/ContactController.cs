using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IServiceManager _manager;

        public ContactController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Form verilerini al ve işle
        [HttpPost]
        public IActionResult SendMessage([FromForm] Contact model)
        {
            if (ModelState.IsValid)
            {
                _manager.ContactService.CreateContact(model);
                return RedirectToAction("Index","Home");
            }

            // Hata durumunda formu yeniden göster
            return View("Index", model);
        }
    }
}
