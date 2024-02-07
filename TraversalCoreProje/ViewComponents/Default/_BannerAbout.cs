using Business.Concrate;
using DataAccess.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _BannerAbout : ViewComponent
    {
        BannerAboutManager bannerAboutManager = new BannerAboutManager(new EfBannerAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = bannerAboutManager .TGetList();
            return View(values);
        }
    }
}
