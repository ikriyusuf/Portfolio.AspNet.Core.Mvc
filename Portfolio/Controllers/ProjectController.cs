using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IServiceManager _manager;

        public ProjectController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ProjectService.GetAllProject(false);
            return View(model);
        }
    }
}
