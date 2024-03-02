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
    public class RoomTypeManager : IRoomTypeService
    {
        IRoomTypeDal _roomTypeDal;

        public RoomTypeManager(IRoomTypeDal roomTypeDal)
        {
            _roomTypeDal = roomTypeDal;
        }

        public RoomType GetById(int id)
        {
            return _roomTypeDal.Get(x => x.RoomTypeId == id);
        }

        public void TAdd(RoomType Entity)
        {
            _roomTypeDal.Add(Entity);
        }

        public void TDelete(RoomType Entity)
        {
            _roomTypeDal.Delete(Entity);
        }

        public List<RoomType> TGetAll()
        {
            return _roomTypeDal.GetAll();
        }

        public void TUpdate(RoomType Entity)
        {
            _roomTypeDal.Update(Entity);
        }
    }
}
