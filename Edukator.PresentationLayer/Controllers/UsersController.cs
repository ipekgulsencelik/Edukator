using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
	public class UsersController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public UsersController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}
		
		public IActionResult Index()
		{
			var values = _userManager.Users.ToList();
		
			return View(values);
		}
	}
}