using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Portfolio.Component.ExperienceCount
{
    public class ExperienceCountViewComponent: ViewComponent
    {
        private readonly IServiceManager _manager;

        public ExperienceCountViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var experienceCount = _manager.ExperienceService.GetAllExperience(false).Count();
            return Content(experienceCount.ToString());
        }
    }
}
