using Edukator.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Dashboard
{
    public class _DashboardLastFiveCoursePartial : ViewComponent
    {
        private readonly ICourseService _courseService;
        
        public _DashboardLastFiveCoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetLastFiveCourse();

            return View(values);
        }
    }
}