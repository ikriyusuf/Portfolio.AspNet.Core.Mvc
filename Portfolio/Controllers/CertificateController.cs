using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Controllers
{
    public class CertificateController : Controller
    {
        public readonly IServiceManager _serviceManager;

        public CertificateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public IActionResult Index()
        {
            var model = _serviceManager.CertificateService.GetAllCertificate(false);
            return View(model);
        }
    }
}
