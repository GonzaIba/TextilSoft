using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business.Services
{
    public class PermisoService : GenericService<PermisoModel>, IPermisoService
    {
        public PermisoService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<IPermisoRepository>())
        {
        }

        public List<PermisoModel> ObtenerPermisos()
        {
            var Permisos = Get(x => x.Permiso != null).ToList();
            return Permisos;
        }
    }
}
