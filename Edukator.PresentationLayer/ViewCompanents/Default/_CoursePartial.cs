using Edukator.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewCompanents.Default
{
	public class _CoursePartial : ViewComponent
	{
		private readonly ICourseService _courseService;

		public _CoursePartial(ICourseService courseService)
		{
			_courseService = courseService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _courseService.TGetCoursesWithCategory();

			return View(values);
		}
	}
}