using Contracts.Controllers;
using Contracts.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class UserController : IUserController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserService _userService;

        public UserController(UserManager<IdentityUser> userManager, IUserService userService)
        {
            _userManager = userManager;
            _userService = userService;
        }

        public async void CreateUser(IdentityUser appIdentityUser)
        {
            try
            {
                appIdentityUser.Email = "gonza@hotmail.com";
                appIdentityUser.UserName = "Gonzalo123";
                //_userService.Insertar(appIdentityUser);
                var result = await _userManager.CreateAsync(appIdentityUser, "1234567");
                var result2 = _userService.GetAll();
                if(result.Succeeded)
                {
                    
                }
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
