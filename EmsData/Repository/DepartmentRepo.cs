using EmsData.EmsDataContext;
using EmsEntity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmsData.Repository
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly EmsDbContext _context;

        public DepartmentRepo(EmsDbContext context)
        {
            _context = context;
        }

        public IList<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.Find(id);
        }

        public Department GetDepartmentByDeptId(int deptId)
        {
            return _context.Departments.FirstOrDefault(d => d.Dept_ID == deptId);
        }

        public bool AddDepartment(Department department)
        {
            try
            {
                _context.Database.ExecuteSqlRaw("INSERT INTO Departments (Dept_Name) VALUES ({0})", department.Dept_Name);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool UpdateDepartment(Department department)
        {
            try
            {
                _context.Entry(department).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteDepartment(int id)
        {
            try
            {
                var department = _context.Departments.Find(id);
                if (department != null)
                {
                    _context.Departments.Remove(department);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
