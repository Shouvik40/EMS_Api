using EmsData.Services;
using EmsEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EMS_Proj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeMasterController : ControllerBase
    {
        private readonly GradeMasterService _gradeMasterService;

        public GradeMasterController(GradeMasterService gradeMasterService)
        {
            _gradeMasterService = gradeMasterService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Grade_Master>> GetAllGradeMasters()
        {
            try
            {
                var gradeMasters = _gradeMasterService.GetAllGradeMasters();
                return Ok(gradeMasters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{code}")]
        public ActionResult<Grade_Master> GetGradeMasterByCode(string code)
        {
            try
            {
                var gradeMaster = _gradeMasterService.GetGradeMasterByCode(code);
                if (gradeMaster == null)
                {
                    return NotFound();
                }
                return Ok(gradeMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<Grade_Master> AddGradeMaster(Grade_Master gradeMaster)
        {
            try
            {
                _gradeMasterService.AddGradeMaster(gradeMaster);
                return CreatedAtAction(nameof(GetGradeMasterByCode), new { code = gradeMaster.Grade_Code }, gradeMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{code}")]
        public IActionResult UpdateGradeMaster(string code, Grade_Master gradeMaster)
        {
            try
            {
                if (code != gradeMaster.Grade_Code)
                {
                    return BadRequest("Grade code mismatch");
                }

                _gradeMasterService.UpdateGradeMaster(gradeMaster);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{code}")]
        public IActionResult DeleteGradeMaster(string code)
        {
            try
            {
                _gradeMasterService.DeleteGradeMaster(code);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
