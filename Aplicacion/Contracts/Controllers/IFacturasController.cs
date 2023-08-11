using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Controllers
{
    public interface IFacturasController
    {
        /// <summary>
        /// Genera una factura a partir de un numero de pedido
        /// </summary>
        /// <param name="NumeroPedido"></param>
        /// <param name="nota"></param>
        /// <param name="DNIEmpleado"></param>
        public void GenerarFactura(int NumeroPedido, string nota, int DNIEmpleado);
    }
}
