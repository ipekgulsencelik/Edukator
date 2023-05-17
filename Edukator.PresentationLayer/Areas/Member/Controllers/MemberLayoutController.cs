using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        
        public MemberLayoutController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.fullName = values.Name + " " + values.Surname;

            return View();
        }
        
        public async Task<PartialViewResult> MemberSideBarPartial()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.fullName = values.Name + " " + values.Surname;

            return PartialView();
        }
    }
}