using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IEmpleadosService : IGenericService<EmpleadosModel>
    {
        public EmpleadosModel EmpleadoLogueado { get; set; }

        /// <summary>
        /// Se loguea el empleado en el sistema
        /// </summary>
        /// <param name="empleadosModel"></param>
        public void LoginEmpleado(EmpleadosModel empleadosModel);
    }
}