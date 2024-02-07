namespace TraversalCoreProje.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string imageUrl { get; set; }
        public IFormFile Image { get; set; }

    }
}
