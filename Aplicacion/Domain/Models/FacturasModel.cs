using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class FacturasModel : GenericEntity
    {
        public int ID_Factura { get; set; }
        public Nullable<int> NumeroFactura { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> TotalPago { get; set; }
        public int ID_Pedido { get; set; }

        public virtual PedidosModel Pedidos { get; set; }
    }
}
