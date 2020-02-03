using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AdminWebAPI.Entities;
using AdminWebAPI.Helpers;
using AdminWebAPI.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AdminWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //private IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppSettings _appSettings;

        public UsersController(
            IOptions<AppSettings> appSettings, SignInManager<ApplicationUser> signInManager)
        {
            _appSettings = appSettings.Value;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Authenticate([FromBody]UserEnt userParam)
        {
            var result = _signInManager.PasswordSignInAsync(userParam.username, userParam.password, true, lockoutOnFailure: false);
            if (!result.Result.Succeeded)
            {
                return BadRequest(new { message = "Tên đăng nhập và mật khẩu không đúng!" });
            }
            var user = _userManager.FindByNameAsync(userParam.username);
            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var userEnt = new UserEnt();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userEnt.token = tokenHandler.WriteToken(token);
            userEnt.username = userParam.username;
            userEnt.password = null;

            return Ok(user);
        }
    }
}