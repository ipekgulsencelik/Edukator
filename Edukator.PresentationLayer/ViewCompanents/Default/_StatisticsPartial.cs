using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.courseCount = context.Courses.Count();
            ViewBag.userCount = 684;

            return View();
        }
    }
}
