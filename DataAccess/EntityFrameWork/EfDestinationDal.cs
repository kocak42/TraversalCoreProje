
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfDestinationDal : GenericRepository<Destination,Context>, IDestinationDal
{

}
