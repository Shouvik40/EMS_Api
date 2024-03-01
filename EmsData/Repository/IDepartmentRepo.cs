using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Repository
{
    public interface IDepartmentRepo
    {
        IList<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        Department GetDepartmentByDeptId(int deptId);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
    }
}
