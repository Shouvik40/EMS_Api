using EmsData.Services;
using EmsEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EMS_Proj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(string id)
        {
            try
            {
                var employee = _employeeService.GetEmployeeById(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<IEnumerable<Employee>> AddEmployee(Employee employee)
        {
            try
            {
                Console.WriteLine(employee);
                _employeeService.AddEmployee(employee);
        
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        public ActionResult<IEnumerable<Employee>> UpdateEmployee(Employee employee)
        {
            try
            {
                _employeeService.UpdateEmployee(employee);           
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Employee>> DeleteEmployee(string id)
        {
            try
            {
                _employeeService.DeleteEmployee(id);
                var updatedEmployees = _employeeService.GetAllEmployees();
                return Ok(updatedEmployees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
