using EmsData.Repository;
using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public IList<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAllEmployees();
        }

        public Employee GetEmployeeById(string id)
        {
            return _employeeRepo.GetEmployeeById(id);
        }

        public void AddEmployee(Employee employee)
        {
            _employeeRepo.AddEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepo.UpdateEmployee(employee);
        }

        public void DeleteEmployee(string id)
        {
            _employeeRepo.DeleteEmployee(id);
        }
    }
}
