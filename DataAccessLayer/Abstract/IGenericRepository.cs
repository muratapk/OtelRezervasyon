using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>where T : class
    {
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T,bool>> filter);//Tek bir veri çağırmak için kullanıyoruz
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Veri Listesi getirmek için kullanıyoruz
    }
}
