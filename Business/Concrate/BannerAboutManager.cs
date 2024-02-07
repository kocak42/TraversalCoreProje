using Business.Abstract;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate;

public class BannerAboutManager: IBannerAboutService
{
    IBannerAboutDal _bannerAboutDal;

    public BannerAboutManager(IBannerAboutDal bannerAboutDal)
    {
        _bannerAboutDal = bannerAboutDal;
    }

    public void TAdd(BannerAbout t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(BannerAbout t)
    {
        throw new NotImplementedException();
    }


    public List<BannerAbout> TGetList()
    {
        return _bannerAboutDal.GetList();
    }

    public void TUpdate(BannerAbout t)
    {
        throw new NotImplementedException();
    }

    public BannerAbout TGetById(int id)
    {
        throw new NotImplementedException();
    }
}
