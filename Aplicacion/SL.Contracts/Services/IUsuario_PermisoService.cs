using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts.Services
{
    public interface IUsuario_PermisoService : IGenericService<Usuario_PermisoModel>
    {
        void GuardarPermisos(Usuario_PermisoModel usuario,List<Usuario_PermisoModel> permisos);
        void EliminarPermisoDeUsuario(Usuario_PermisoModel usuario);
    }
}
