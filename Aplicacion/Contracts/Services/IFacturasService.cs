using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IFacturasService : IGenericService<FacturasModel>
    {
        /// <summary>
        /// Genera una factura y actualiza el pedido a entregado
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="pedido"></param>
        public void CrearFactura(FacturasModel factura, PedidosModel pedido);
    }
}
