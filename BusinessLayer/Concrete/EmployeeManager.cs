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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public Employee GetById(int id)
        {
           return _employeeDal.Get(x=>x.StaffId == id);
        }

        public void TAdd(Employee Entity)
        {
            _employeeDal.Add(Entity);
        }

        public void TDelete(Employee Entity)
        {
            _employeeDal.Delete(Entity);
        }

        public List<Employee> TGetAll()
        {
            return _employeeDal.GetAll();
        }

        public void TUpdate(Employee Entity)
        {
            _employeeDal.Update(Entity);
        }
    }
}
