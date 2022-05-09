using Contracts.Controllers;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class EmpleadosController : IEmpleadosController
    {
        private readonly IEmpleadosService _empleadosService;
        public EmpleadosController(IEmpleadosService empleadosService)
        {
            _empleadosService = empleadosService;
        }
        
        public bool UserLogged()
        {
            throw new NotImplementedException();
        }
    }
}
