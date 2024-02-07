using Business.Concrate;
using DataAccess.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        SecondFeatureManager featureManager = new SecondFeatureManager(new EfSecondFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View( values);
        }
    }
}
