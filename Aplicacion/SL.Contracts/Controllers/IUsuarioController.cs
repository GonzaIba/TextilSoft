using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public interface IUsuarioController
    {
        void CreateUser(IdentityUser appIdentityUser);
        Task<bool> LoginUser(IdentityUser appIdentityUser);
    }
}
