using BusinessLayer.Abstract;
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
        public Hostel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Hostel Entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Hostel Entity)
        {
            throw new NotImplementedException();
        }

        public List<Hostel> TGetAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Hostel Entity)
        {
            throw new NotImplementedException();
        }
    }
}
