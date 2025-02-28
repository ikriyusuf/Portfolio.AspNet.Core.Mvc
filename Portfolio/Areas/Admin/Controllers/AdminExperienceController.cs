using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminExperienceController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminExperienceController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.ExperienceService.GetAllExperience(false);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Experience experience)
        {
            if (ModelState.IsValid)
            {
            _manager.ExperienceService.CreateExperience(experience);
            return RedirectToAction("Index","AdminExperience");
            }
            return View();
        }

        public IActionResult Delete([FromRoute(Name = "id")] int id)
        {
            _manager.ExperienceService.DeleteExperience(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
           var experienceDto =  _manager.ExperienceService.GetOneExperienceUpdateDto(id, false);
            return View(experienceDto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] ExperienceUpdateDto experienceDto)
        {
            if (ModelState.IsValid)
            {
            _manager.ExperienceService.UpdateExperience(experienceDto);
            return RedirectToAction("Index");
            }

            return View();
        }

    }
}
