using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IVentasController
    {
        /// <summary>
        /// Se registra una venta y el DNI del empleado que atendió
        /// </summary>
        /// <param name="ventasEntity"></param>
        /// <param name="DNI"></param>
        public void RegistrarVenta(VentasEntity ventasEntity, string DNI);
    }
}
