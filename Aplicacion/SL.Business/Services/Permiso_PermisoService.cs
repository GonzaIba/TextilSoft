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
    public class Permiso_PermisoService : GenericService<Permiso_PermisoModel>, IPermiso_PermisoService
    {
        public Permiso_PermisoService(IUnitOfWork unitOfWork)
        : base(unitOfWork, unitOfWork.GetRepository<IPermiso_PermisoRepository>())
        {
            
        }

        public void GuardarFamilia(Permiso_PermisoModel Padre, List<Permiso_PermisoModel> Hijos)
        {
            var HijosDelPadre = Get(x => x.Id_Permiso_Padre == Padre.Id_Permiso_Padre, tracking: true).ToList();
            if(HijosDelPadre.Count > 0)
                Eliminar(HijosDelPadre);//Eliminamos todas las relaciones que tenia la familia

            //Recorremos hijos e insertamos con el id del padre
            foreach (var hijo in Hijos)
            {
                hijo.Id_Permiso_Padre = Padre.Id_Permiso_Padre;
                Insertar(hijo);
            }
            _unitOfWork.SaveChanges();
        }
    }
}
