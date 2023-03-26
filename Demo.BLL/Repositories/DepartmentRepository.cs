using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly MVC_ProjectDbContext _dbContext;

        public DepartmentRepository(MVC_ProjectDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
        //private readonly MVC_ProjectDbContext _dbContext;

        //public DepartmentRepository(MVC_ProjectDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        //public int Add(Department department)
        //{
        //    _dbContext.Add(department);
        //    return _dbContext.SaveChanges();
        //}

        //public int Delete(Department department)
        //{
        //    _dbContext.Remove(department);
        //    return _dbContext.SaveChanges();
        //}

        //public Department Get(int id)
        //    => _dbContext.Departments.Where(D => D.Id == id).FirstOrDefault();

        //public IEnumerable<Department> GetAll()
        //    => _dbContext.Departments.ToList();

        //public int Update(Department department)
        //{
        //    _dbContext.Update(department);
        //    return _dbContext.SaveChanges();
        //}
    }
}
