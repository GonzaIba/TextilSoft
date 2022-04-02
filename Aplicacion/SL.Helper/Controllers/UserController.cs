using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Controllers
{
    public class UserController : IUsuarioController
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUsuarioService _userService;

        public UserController(/*UserManager<IdentityUser> userManager*/ IUsuarioService userService)
        {
            //_userManager = userManager;
            _userService = userService;
        }

        public async void CreateUser(IdentityUser appIdentityUser)
        {
            try
            {
                appIdentityUser.Email = "gonza_28.00@hotmail.com";
                appIdentityUser.UserName = "Gonza1000";
                //_userService.Insertar(appIdentityUser);
                //var result = await _userManager.ConfirmEmailAsync(appIdentityUser, "CfDJ8NyT3YnESzJLqrWsxE6IlU2TiYoLcJQt9HnvvbXzl+kRtjFC/a1KiQyU7xMij5yD5o2omi1ZaVGnCg8J/k/5fWvI3kk2yb5on7FzGjxSU993pYu6BBiOp2YdSUt1jIglVyb2OkBSF+8ca1HdPmNV/cOD811ZWPqUavIMAWGY5je18sLtG3RCcJKbNo2HfF9IZFuEn8JBP1S57sYJjjx8WxSQYd6fCebBkodRBgoj35aMxHzx5vc9+ogrPLJFxyo+dQ==");
                //var IdentityUserDTO = _userService.Get(x => x.Email == appIdentityUser.Email).FirstOrDefault();
                //var result = await _userManager.GenerateEmailConfirmationTokenAsync(IdentityUserDTO);
                //var result2 = _userService.GetAll();
                //if(result.Succeeded)
                //{

                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> LoginUser(IdentityUser appIdentityUser)
        {
            try
            {
                //appIdentityUser.Email = "gonza@hotmail.com";
                //appIdentityUser.UserName = "Gonzalo123";
                appIdentityUser.Email = "gonza@hotmail.com";
                appIdentityUser.UserName = "asd";
                bool result = await _userManager.CheckPasswordAsync(appIdentityUser, "12345623127");
                if (!result)
                {
                    //await _userManager.AccessFailedAsync(appIdentityUser);
                    return result;
                }
                else
                    return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
