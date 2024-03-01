using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmsEntity;

namespace EmsData.EmsDataContext
{
    public class EmsDbContext:DbContext
    {
        public EmsDbContext(DbContextOptions<EmsDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Grade_Master> Grade_Masters { get; set; }
        public DbSet<User_Master> User_Masters { get; set; }
    }
}
