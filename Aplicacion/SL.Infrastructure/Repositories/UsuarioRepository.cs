using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.Repositories
{
    public class UsuarioRepository : GenericRepository<IdentityUser>, IUsuarioRepository
    {
        public UsuarioRepository(ServiceLayerDbContext context) : base(context)
        {

        }
    }
}
