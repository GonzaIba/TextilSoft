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
        void CrearPermiso(Patente patente); //Agrega una patente a la lista de patentes
        bool Existe(Componente c, int id);
    }
}
