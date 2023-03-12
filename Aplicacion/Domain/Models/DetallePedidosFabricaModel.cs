using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class DetallePedidosFabricaModel : GenericEntity
    {
        public int ID_DetallePedidosFabrica { get; set; }
        public int ID_PedidosFabrica { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }

        public virtual PedidosFabricaModel PedidosFabrica { get; set; }
        public virtual ProductosModel Producto { get; set; }
    }
}
