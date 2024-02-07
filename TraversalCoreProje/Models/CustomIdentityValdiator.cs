using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValdiator: IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Password least {length} must be character"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresUpper",
				Description = "Password must contain at least 1 Upper character "
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresUpper",
				Description = "Password must contain at least 1 Lower character "
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{

				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Password must contain at least 1 Alphanumeric character "
			};
		}
	}
}
