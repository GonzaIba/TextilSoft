using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class HistorialPedidosModel : GenericEntity
    {
        public int ID_HistorialPedidos { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_EstadoPedido { get; set; }
        public DateTime Fecha { get; set; }

        public virtual PedidosModel Pedidos { get; set; }
        public virtual EstadoPedidoModel EstadoPedido { get; set; }
    }
}
