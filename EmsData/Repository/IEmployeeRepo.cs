using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Repository
{
    public interface IEmployeeRepo
    {
        IList<Employee> GetAllEmployees();
        Employee GetEmployeeById(string id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(string id);
    }
}
