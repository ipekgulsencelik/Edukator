using Edukator.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Dashboard
{
    public class _DashboardLastFourMessagePartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _DashboardLastFourMessagePartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetLastFourMessage();

            return View(values);
        }
    }
}