using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfTestimonialDal : GenericRepository<Testimonial,Context>, ITestimonialDal
{

}
