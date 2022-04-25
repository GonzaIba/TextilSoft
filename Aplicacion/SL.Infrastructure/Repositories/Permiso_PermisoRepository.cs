using SL.Contracts.Repositories;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Infrastructure.Repositories
{
    internal class Permiso_PermisoRepository : GenericRepository<Permiso_PermisoModel>, IPermiso_PermisoRepository
    {
        public Permiso_PermisoRepository(ServiceLayerDbContext context) : base(context)
        {

        }
    }
}
