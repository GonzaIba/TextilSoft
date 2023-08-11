using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IEmpleadosController
    {
        //public void LoginEmpleado(Usuario usuario);
        
        /// <summary>
        /// Verifica si el empleado esta logueado
        /// </summary>
        /// <returns></returns>
        public bool UserLogged();
    }
}
