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
        public int ID_Transfer { get; set; }
        public int Cantidad { get; set; }
        public string Detalle { get; set; }
        public string Color { get; set; }

        public virtual PedidosModel Pedidos { get; set; }
        public virtual ProductosModel Producto { get; set; }
        public virtual TransferModel Transfer { get;set; }
    }
}
