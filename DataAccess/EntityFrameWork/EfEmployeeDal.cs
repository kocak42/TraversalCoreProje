
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfEmployeeDal : GenericRepository<Employee,Context>, IEmployeeDal
{

}
