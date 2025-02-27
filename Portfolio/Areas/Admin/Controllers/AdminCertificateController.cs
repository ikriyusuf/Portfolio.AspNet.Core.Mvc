using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminCertificateController : Controller
    {
        private readonly IServiceManager _manager;

        public AdminCertificateController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var model = _manager.CertificateService.GetAllCertificate(false);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromForm] Certificate certificateModel)
        {
            if (ModelState.IsValid)
            {
                _manager.CertificateService.CreateCertificate(certificateModel);
                return RedirectToAction("Index", "AdminCertificate");
            }
            return View();
        }
        public IActionResult Update(int id)
        {
            var model = _manager.CertificateService.GetOneCertificateForUpdate(id, false);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([FromForm] CertificateUpdateDto certificateDto)
        {
            if (ModelState.IsValid)
            {
                _manager.CertificateService.UpdateCertificate(certificateDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete([FromRoute(Name ="id")] int id)
        {
            _manager.CertificateService.DeleteCertificate(id);
            return RedirectToAction("Index");
        }
    }
}
