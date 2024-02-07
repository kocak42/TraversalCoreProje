using Business.Concrate;
using DataAccess.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.Branches = c.Destinations.Count();
            ViewBag.Guides = c.Employees.Count();
            ViewBag.Customers = "285";
            return View();
        }
    }
}
