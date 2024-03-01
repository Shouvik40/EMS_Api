using EmsData.Services;
using EmsEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EMS_Proj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserMasterController : ControllerBase
    {
        private readonly UserMasterService _userMasterService;

        public UserMasterController(UserMasterService userMasterService)
        {
            _userMasterService = userMasterService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User_Master>> GetAllUserMasters()
        {
            try
            {
                var userMasters = _userMasterService.GetAllUserMasters();
                return Ok(userMasters);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<User_Master> GetUserMasterById(string id)
        {
            try
            {
                var userMaster = _userMasterService.GetUserMasterById(id);
                if (userMaster == null)
                {
                    return NotFound();
                }
                return Ok(userMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<User_Master> AddUserMaster(User_Master userMaster)
        {
            try
            {
                _userMasterService.AddUserMaster(userMaster);
                return CreatedAtAction(nameof(GetUserMasterById), new { id = userMaster.UserID }, userMaster);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserMaster(string id, User_Master userMaster)
        {
            try
            {
                if (id != userMaster.UserID)
                {
                    return BadRequest("User ID mismatch");
                }

                _userMasterService.UpdateUserMaster(userMaster);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserMaster(string id)
        {
            try
            {
                _userMasterService.DeleteUserMaster(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
