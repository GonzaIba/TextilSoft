using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business
{
    public class UserService : GenericService<IdentityUser>, IUsuarioService
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserService(
            IUnitOfWork unitOfWork,
            UserManager<IdentityUser> userManager)
            : base(unitOfWork, unitOfWork.GetRepository<IUsuarioRepository>())
        {
            _userManager = userManager;
        }


    }
}
