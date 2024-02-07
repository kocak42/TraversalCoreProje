
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfCommentDal : GenericRepository<Comment, Context>, ICommentDal
{

}