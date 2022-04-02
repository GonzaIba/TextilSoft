using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class DetallePedidosModel : GenericEntity
    {
        public int ID_DetallePedido { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
        public string Cantidad { get; set; }

        public virtual PedidosModel Pedidos { get; set; }
        public virtual ProductosModel Producto { get; set; }
    }
}
