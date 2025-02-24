using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly IServiceManager _serviceManager;
  
    public HomeController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    public IActionResult Index()
    {
        var model = _serviceManager.PersonalService.GetAllPersonal(false).FirstOrDefault();
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
