using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class SubscribeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
