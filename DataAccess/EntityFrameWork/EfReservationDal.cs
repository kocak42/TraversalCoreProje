
using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repository;
using Entity.Concrate;

public class EfReservationDal : GenericRepository<Reservation, Context>, IReservationDal
{

}