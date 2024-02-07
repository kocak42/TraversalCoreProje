using Business.Abstract;
using Core.Utilities.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate;

public class TestimonialManager: ITestomonialService
{
    ITestimonialDal _testimonialDal;

    public TestimonialManager(ITestimonialDal testimanialDal)
    {
        _testimonialDal = testimanialDal;
    }

    public void TAdd(Testimonial t)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Testimonial t)
    {
        throw new NotImplementedException();
    }

    public Testimonial TGetById(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Testimonial> TGetList()
    {
        return _testimonialDal.GetList();
    }

    public void TUpdate(Testimonial t)
    {
        throw new NotImplementedException();
    }
}
