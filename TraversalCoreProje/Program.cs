
using DataAccess.Concrate;
using Entity.Concrate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using TraversalCoreProje;





namespace TraversalCoreProject
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();



//builder.Services.AddDbContext<Context>();
//builder.Services.AddIdentity<AppUser, AppRole>();
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//	.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
//		options => builder.Configuration.Bind("JwtSettings", options))
//	.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
//		options => builder.Configuration.Bind("CookieSettings", options));

//builder.Services.AddControllersWithViews();
//builder.Services.AddMvc(config =>
//{
//	var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
//				.Build();
//	config.Filters.Add(new AuthorizeFilter(policy));
//});
//builder.Services.AddMvc();
//var app = builder.Build();

//{

//}

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}


//app.UseHttpsRedirection();
//app.UseStaticFiles();
////app.UseAuthentication();
//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
