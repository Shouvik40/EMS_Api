using EmsData.Repository;
using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Services
{
    public class DepartmentService
    {
        private readonly IDepartmentRepo _departmentRepo;

        public DepartmentService(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public IList<Department> GetAllDepartments()
        {
            return _departmentRepo.GetAllDepartments();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepo.GetDepartmentById(id);
        }

        public Department GetDepartmentByDeptId(int deptId)
        {
            return _departmentRepo.GetDepartmentByDeptId(deptId);
        }

        public void AddDepartment(Department department)
        {
            _departmentRepo.AddDepartment(department);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepo.UpdateDepartment(department);
        }

        public void DeleteDepartment(int id)
        {
            _departmentRepo.DeleteDepartment(id);
        }
    }
}
