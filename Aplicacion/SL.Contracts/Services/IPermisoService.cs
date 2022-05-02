using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts.Services
{
    public interface IPermisoService : IGenericService<PermisoModel>
    {
        /// <summary>
        /// Devuelve los permisos
        /// </summary>
        /// <returns></returns>
        List<PermisoModel> ObtenerPermisos();
        void GuardarFamilia(Familia c);
    }
}
