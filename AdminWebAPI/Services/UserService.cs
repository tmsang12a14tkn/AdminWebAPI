using AdminWebAPI.Entities;
using AdminWebAPI.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace AdminWebAPI.Services
{
    public interface IUserService
    {
        UserEnt Authenticate(string username, string password);
        //IEnumerable<UserEnt> GetAll();
    }

    public class UserService
    {
        

        public UserService(IOptions<AppSettings> appSettings, SignInManager<ApplicationUser> signInManager)
        {
            //_appSettings = appSettings.Value;
            //_signInManager = signInManager;
        }

        //public UserEnt Authenticate(string username, string password)
        //{
        //    ////var result = _signInManager.PasswordSignInAsync(username, password, true, lockoutOnFailure: false);
        //    ////if (!result.Result.Succeeded)
        //    ////{
        //    ////    return null;
        //    ////}
        //    ////var user = _userManager.FindByNameAsync(username);
        //    ////// authentication successful so generate jwt token
        //    ////var tokenHandler = new JwtSecurityTokenHandler();
        //    ////var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        //    ////var tokenDescriptor = new SecurityTokenDescriptor
        //    ////{
        //    ////    Subject = new ClaimsIdentity(new Claim[]
        //    ////    {
        //    ////        new Claim(ClaimTypes.Name, user.Id.ToString())
        //    ////    }),
        //    ////    Expires = DateTime.UtcNow.AddDays(7),
        //    ////    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    ////};
        //    ////var userEnt = new UserEnt();
        //    ////var token = tokenHandler.CreateToken(tokenDescriptor);
        //    ////userEnt.token = tokenHandler.WriteToken(token);
        //    ////userEnt.username = username;
        //    ////userEnt.password = null;

        //    //return userEnt;
        //}

        //public IEnumerable<UserEnt> GetAll()
        //{
        //    // return users without passwords
        //    return _users.Select(x => {
        //        x.Password = null;
        //        return x;
        //    });
        //}
    }
}
