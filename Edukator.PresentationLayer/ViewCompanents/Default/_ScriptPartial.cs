using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Default
{
	public class _ScriptPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
