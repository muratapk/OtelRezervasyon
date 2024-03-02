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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public Customer GetById(int id)
        {
            return _customerDal.Get(x=>x.CustomerId== id);  
        }

        public void TAdd(Customer Entity)
        {
            _customerDal.Add(Entity);
        }

        public void TDelete(Customer Entity)
        {
            _customerDal.Delete(Entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public void TUpdate(Customer Entity)
        {
            _customerDal.Update(Entity);
        }
    }
}
