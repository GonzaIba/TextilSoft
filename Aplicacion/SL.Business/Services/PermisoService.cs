using SL.Contracts;
using SL.Contracts.Repositories;
using SL.Contracts.Services;
using SL.Domain.Entities;
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
        private readonly IPermiso_PermisoRepository _permiso_PermisoRepository;
        public PermisoService(IUnitOfWork unitOfWork,IPermiso_PermisoRepository permiso_PermisoRepository)
        : base(unitOfWork, unitOfWork.GetRepository<IPermisoRepository>())
        {
            _permiso_PermisoRepository = permiso_PermisoRepository;
        }

        public void GuardarFamilia(Familia c)
        {
            //
        }

        public List<PermisoModel> ObtenerPermisos()
        {
            var Permisos = Get().ToList();
            return Permisos;
        }
    }
}
