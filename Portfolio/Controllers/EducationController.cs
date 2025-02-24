using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public EducationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public IActionResult Index()
        {
            var model = _serviceManager.EducationService.GetAllEducation(false);
            return View(model);
        }
    }
}
