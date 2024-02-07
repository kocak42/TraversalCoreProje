using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;

public class ReservationManager : IReservationService
{
    IReservationDal _reservationDal;

    public ReservationManager(IReservationDal reservationDal)
    {
        _reservationDal = reservationDal;
    }

    public void TAdd(Reservation t)
    {
        _reservationDal.Add(t);
    }

    public void TDelete(Reservation t)
    {
        _reservationDal.Delete(t);
    }

    public Reservation TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Reservation> TGetList()
    {
        return _reservationDal.GetList();
    }

    public void TUpdate(Reservation t)
    {
        throw new NotImplementedException();
    }
}