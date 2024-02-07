
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfContactDal : GenericRepository<Contact,Context>, IContactDal
{

}
