using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
         ApplicationDbContext _context=new ApplicationDbContext();
        public GenericRepository()
        {
           
        }

        public void Add(T entity)
        {
            var addEntity = _context.Add(entity);
            _context.SaveChanges();
        }
       
        public void Delete(T entity)
        {
            var deleteEntity = _context.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().FirstOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var updateEntity = _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
