
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfSecondFeatureDal : GenericRepository<SecondFeature,Context>, ISecondFeatureDal
{

}
