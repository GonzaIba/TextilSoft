using SL.Contracts.Repositories;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.Repositories
{
    public class Usuario_PermisoRepository : GenericRepository<Usuario_PermisoModel>, IUsuario_PermisoRepository
    {
        public Usuario_PermisoRepository(ServiceLayerDbContext context) : base(context)
        {

        }
    }
}
