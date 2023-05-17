using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Default
{
	public class _TestimonialPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
