using Business.Abstract;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate;

public class FirstAboutManager : IFirstAboutService
{
    IFirstAboutDal _firstAboutDal;

    public FirstAboutManager(IFirstAboutDal firstAboutDal)
    {
        _firstAboutDal = firstAboutDal;
    }

    public void TAdd(FirstAbout t)
    {
        _firstAboutDal.Add(t);
    }

    public void TDelete(FirstAbout t)
    {
        _firstAboutDal.Delete(t);
    }

    public IDataResult<FirstAbout> GetById(int Id)
    {
        throw new NotImplementedException();
    }


    public List<FirstAbout> TGetList()
    {
       return _firstAboutDal.GetList();
    }

    public void TUpdate(FirstAbout t)
    {
        _firstAboutDal.Update(t);
    }

    FirstAbout Abstract.IGenericService<FirstAbout>.TGetById(int Id)
    {
        throw new NotImplementedException();
    }
}