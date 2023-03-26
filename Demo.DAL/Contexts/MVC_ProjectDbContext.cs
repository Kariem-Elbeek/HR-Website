using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class MVC_ProjectDbContext : IdentityDbContext<ApplicationUser>
    {
        public MVC_ProjectDbContext(DbContextOptions<MVC_ProjectDbContext> options):base(options)
        {

        }
        public MVC_ProjectDbContext()
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server = .; Database = MVC_ProjectDb; Trusted_Connection = true; MultipleActiveResultSets = true");

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<ApplicationUser> AspNetUsers { get; set; }
    }
}
