using EmsEntity;
using EmsServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<ActionResult<User_Master>> Login(LoginRequestModel model)
        {
            var user = await _loginService.Authenticate(model.UserName, model.password, model.UserType);

            if (user == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok(user);
        }
    }

    public class LoginRequestModel
    {
        public string UserName { get; set; }
        public string password { get; set; }
        public string UserType { get; set; }
    }

}
