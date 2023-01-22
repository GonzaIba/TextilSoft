using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public interface IPermisosController
    {
        List<Patente> ObtenerPermisos(); //Devuelve la lista de patentes (que no sean null)
        void CrearPermiso(Componente c); //Aca creamos una familia o una patente...
        bool Existe(Componente c, int id);
        void GuardarFamilia(Familia c);
        void GuardarPermisos(Usuario u);
        void EliminarPermiso(Componente c);
    }
}
