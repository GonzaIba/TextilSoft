using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IUserController
    {
        void CreateUser(IdentityUser appIdentityUser);
    }
}
