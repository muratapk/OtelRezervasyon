using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public Booking GetById(int id)
        {
            return _bookingDal.Get(x=>x.BookId == id);

        }

        public void TAdd(Booking Entity)
        {
            _bookingDal.Add(Entity);
        }

        public void TDelete(Booking Entity)
        {
            _bookingDal.Delete(Entity);
        }

        public List<Booking> TGetAll()
        {
            return _bookingDal.GetAll();
        }

        public void TUpdate(Booking Entity)
        {
            throw new NotImplementedException();
        }
    }
}
