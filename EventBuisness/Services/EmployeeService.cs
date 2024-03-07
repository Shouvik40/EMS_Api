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

        public bool AddEmployee(Employee employee)
        {
            try
            {
                _employeeRepo.AddEmployee(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                _employeeRepo.UpdateEmployee(employee);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteEmployee(string id)
        {
            try
            {
                _employeeRepo.DeleteEmployee(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
