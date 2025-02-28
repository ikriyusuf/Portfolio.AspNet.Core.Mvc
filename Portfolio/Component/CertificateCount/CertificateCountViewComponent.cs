using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Component.CertificateCount
{
    public class CertificateCountViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public CertificateCountViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var certificateCount = _manager.CertificateService.GetAllCertificate(false).Count();
            return Content(certificateCount.ToString());
        }
    }
}
