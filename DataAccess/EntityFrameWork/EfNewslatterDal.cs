
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfNewslatterDal : GenericRepository<Newslatter,Context>, INewslatterDal
{

}
