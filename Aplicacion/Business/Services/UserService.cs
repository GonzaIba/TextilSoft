using Contracts.Repositories;
using Contracts.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : GenericService<IdentityUser>, IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        public UserService(
            IUnitOfWork unitOfWork,
            UserManager<IdentityUser> userManager)
            : base(unitOfWork, unitOfWork.GetRepository<IUserRepository>())
        {
            _userManager = userManager;
        }


    }
}
