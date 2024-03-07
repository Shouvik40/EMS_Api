using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Repository
{
    public interface IDepartmentRepo
    {
        IList<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        Department GetDepartmentByDeptId(int deptId);
        bool AddDepartment(Department department); // Change return type to bool
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(int id);
    }
}
