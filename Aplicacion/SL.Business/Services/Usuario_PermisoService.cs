using Microsoft.Extensions.Configuration;
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
    public class Usuario_PermisoService : GenericService<Usuario_PermisoModel>, IUsuario_PermisoService
    {
        private readonly IConfiguration _configuration;
        public Usuario_PermisoService(IUnitOfWork unitOfWork, IConfiguration configuration)
        : base(unitOfWork, unitOfWork.GetRepository<IUsuario_PermisoRepository>())
        {
            _configuration = configuration;
        }

        public void GuardarPermisos(Usuario_PermisoModel usuario, List<Usuario_PermisoModel> permisos)
        {
            var PermisosDelUsuario = Get(x => x.Id_Usuario == usuario.Id_Usuario).ToList();
            Eliminar(PermisosDelUsuario);

            foreach (var permiso in permisos)
            {
                Insertar(permiso);
            }
            _unitOfWork.Save();
        }
    }
}
