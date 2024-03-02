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
    public class HostelManager : IHostelService
    {
        //classın üzerine gel ctrl nokta bas consturctur oluştur
        IHostelDal _HostelDal;

        public HostelManager(IHostelDal HostelDal)
        {
            _HostelDal = HostelDal;
        }

        //bu servis vasıta ile direkt veritabanı bağlanmak bir tanımlama oluşturdum.
        public Hostel GetById(int id)
        {
            return _HostelDal.Get(x=>x.HostelId== id);
            //throw new NotImplementedException();
        }

        public void TAdd(Hostel Entity)
        {
            _HostelDal.Add(Entity);
        }

        public void TDelete(Hostel Entity)
        {
            _HostelDal.Delete(Entity);
        }

        public List<Hostel> TGetAll()
        {
            return _HostelDal.GetAll();
        }

        public void TUpdate(Hostel Entity)
        {
            _HostelDal.Update(Entity);
        }
    }
}
