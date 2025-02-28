using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

public class ProjectCountViewComponent : ViewComponent
{
    private readonly IServiceManager _manager;

    public ProjectCountViewComponent(IServiceManager manager)
    {
        _manager = manager;
    }

    // Döndürülen değer doğrudan int ya da string olmalı
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var projectCount = _manager.ProjectService.GetAllProject(false).Count();
        return Content(projectCount.ToString());
    }
}
