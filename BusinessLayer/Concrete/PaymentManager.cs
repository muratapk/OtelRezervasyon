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
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public Payment GetById(int id)
        {
            return _paymentDal.Get(x => x.PaymentId == id);

        }

        public void TAdd(Payment Entity)
        {
            _paymentDal.Add(Entity);
        }

        public void TDelete(Payment Entity)
        {
            _paymentDal.Delete(Entity);
        }

        public List<Payment> TGetAll()
        {
           return _paymentDal.GetAll();
        }

        public void TUpdate(Payment Entity)
        {
            _paymentDal.Update(Entity);
        }
    }
}
