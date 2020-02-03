using Data.Manage.Entities;
using Data.Manage.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repo.Manage;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Manage
{
    public interface IUserService
    {
        Task<UserEnt> Authenticate(string username, string password);
    }

    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, 
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _appSettings = appSettings.Value;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<UserEnt> Authenticate(string username, string password)
        {
            var result = _signInManager.PasswordSignInAsync(username, password, true, lockoutOnFailure: false);
            if (!result.Result.Succeeded)
            {
                return null;
            }
            ApplicationUser user = await _userManager.FindByNameAsync(username);
            IList<string> roles = await _userManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Id.ToString())
            };
            claims.AddRange(roles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType, role)));

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var userEnt = new UserEnt();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            userEnt.token = tokenHandler.WriteToken(token);
            userEnt.username = username;
            userEnt.password = null;

            return userEnt;
        }

    }
}
