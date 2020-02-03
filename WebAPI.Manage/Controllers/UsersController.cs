using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Data.Manage.Entities;
using Service.Manage;
using System.Threading.Tasks;

namespace WebAPI.Manage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public async Task<IActionResult> Authenticate([FromBody]UserEnt userParam)
        {
            var user = await _userService.Authenticate(userParam.username, userParam.password);

            if (user == null)
                return Ok(new { code = 0, message = "Tên đăng nhập hoặc mật khẩu không đúng!" });

            return Ok(new { code = 1, data = user });
        }
    }
}