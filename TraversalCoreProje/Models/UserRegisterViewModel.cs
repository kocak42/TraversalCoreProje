using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Please enter your name")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please enter your last name")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Please enter your  user name")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Please enter your Email")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Please enter your password")]
		public string Password { get; set; }


		[Required(ErrorMessage = "Please enter your password")]
		[Compare("Password",ErrorMessage ="Passwords are not compatible")]
		public string ConfirmPassword { get; set; }
	}
}
