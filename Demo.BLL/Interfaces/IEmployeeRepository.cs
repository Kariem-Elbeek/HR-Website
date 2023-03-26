using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IQueryable<Employee> GetEmployeesByDepartmentName(string depName);
        IQueryable<Employee> SearchEmployeesByName (string name);
        //IEnumerable<Employee> GetAll();
        //Employee Get(int id);
        //int Add(Employee employee);
        //int Update(Employee employee);
        //int Delete(Employee employee);
    }
}
