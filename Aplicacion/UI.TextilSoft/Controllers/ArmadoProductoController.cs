using Contracts.Controllers;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Controllers
{
    public class ArmadoProductoController : IArmadoProductoController
    {
        private readonly IArmadoProductoService _armadoProductoService;
        public ArmadoProductoController(IArmadoProductoService armadoProductoService)
        {
            _armadoProductoService = armadoProductoService;
        }
    }
}
