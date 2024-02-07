
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfFirstAboutDal : GenericRepository<FirstAbout,Context>, IFirstAboutDal
{

}
