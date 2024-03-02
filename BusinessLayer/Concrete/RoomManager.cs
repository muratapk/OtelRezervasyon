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
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public Room GetById(int id)
        {
            return _roomDal.Get(x => x.RoomId == id);
        }

        public void TAdd(Room Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Room Entity)
        {
            throw new NotImplementedException();
        }

        public List<Room> TGetAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Room Entity)
        {
            throw new NotImplementedException();
        }
    }
}
