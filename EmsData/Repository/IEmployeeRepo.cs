using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Repository
{
    public interface IEmployeeRepo
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(string id);
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(string id);
    }
}
