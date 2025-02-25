using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminHomeController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminHomeController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ProjectService.GetAllProject(false);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Project project)
        {

            if (ModelState.IsValid)
            {
                _manager.ProjectService.CreateProject(project);
                TempData["succes"] = $"{project.Title} eklendi.";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var entity = _manager.ProjectService.GetOneProject(id, false);
            return View(entity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] Project project)
        { // 
            if (ModelState.IsValid)
            {
                _manager.ProjectService.UpdateProject(project);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
