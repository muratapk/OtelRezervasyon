using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface IGenericService<T>
    {
        void TAdd(T Entity);
        void TDelete(T Entity);  
        void TUpdate(T Entity);
        List<T> TGetAll();
        T GetById(int id);

    }
}
