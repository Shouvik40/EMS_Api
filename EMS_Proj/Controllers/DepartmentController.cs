using EmsData.Services;
using EmsEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EMS_Proj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService _departmentService;

        public DepartmentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Department>> GetAllDepartments()
        {
            try
            {
                var departments = _departmentService.GetAllDepartments();
                return Ok(departments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Department> GetDepartmentById(int id)
        {
            try
            {
                var department = _departmentService.GetDepartmentById(id);
                if (department == null)
                {
                    return NotFound();
                }
                return Ok(department);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            try
            {
                bool success = _departmentService.AddDepartment(department);
                if (success)
                {
                    return CreatedAtAction(nameof(GetDepartmentById), new { id = department.Dept_ID }, department);
                }
                else
                {
                    return BadRequest("Failed to add department");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult UpdateDepartment(Department department)
        {
            try
            {
                _departmentService.UpdateDepartment(department);
                return Ok(department);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            try
            {
                _departmentService.DeleteDepartment(id);
                var departments = _departmentService.GetAllDepartments;
                return Ok(departments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
