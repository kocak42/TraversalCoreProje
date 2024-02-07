using Entity.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public ProfileController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEditViewModel = new UserEditViewModel();
			userEditViewModel.FirstName = values.Name;
			userEditViewModel.LastName = values.SurName;
			userEditViewModel.phonenumber = values.PhoneNumber;
			userEditViewModel.mail = values.Email;



			return View(userEditViewModel);
		}
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditView)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (userEditView != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(userEditView.Image.FileName);
				var imagename = Guid.NewGuid() + extension;
				var savelacation = resource + "/wwwroot/userimages/" + imagename;
				var stream = new FileStream(savelacation, FileMode.Create);
				await userEditView.Image.CopyToAsync(stream);
				user.ImageUrl = imagename;


			}
			user.Name = userEditView.FirstName;
			user.SurName = userEditView.LastName;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditView.password);
			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}
			return View();

		}
	}
	
	

}
