
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfFirstFeatureDal : GenericRepository<FirstFeature,Context>, IFirstFeatureDal
{

}
