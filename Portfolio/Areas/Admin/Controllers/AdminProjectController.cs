using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminProjectController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminProjectController(IServiceManager manager)
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
        [HttpGet]
        public IActionResult Update([FromRoute(Name = "id")] int id)
        {
            var projectUpdateDto = _manager.ProjectService.GetOneProjectForUpdate(id, false);
            return View(projectUpdateDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] ProjectUpdateDto projectUpdateDto)
        { // 
            if (ModelState.IsValid)
            {
                _manager.ProjectService.UpdateProject(projectUpdateDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.ProjectService.RemoveProject(id);
            return RedirectToAction("Index");
        }
    }
}
