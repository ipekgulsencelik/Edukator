using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Dashboard
{
    public class _DashboardCalenderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
