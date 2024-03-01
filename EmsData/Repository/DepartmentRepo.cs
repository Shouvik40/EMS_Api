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

        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            _context.Entry(department).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}

