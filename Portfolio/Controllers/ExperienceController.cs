using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ExperienceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public IActionResult Index()
        {
            var model = _serviceManager.ExperienceService.GetAllExperience(false);
            return View(model);
        }
    }
}

