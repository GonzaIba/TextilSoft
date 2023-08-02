using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TransferModel : GenericEntity
    {
        public TransferModel()
        {
            DetallePedido = new HashSet<DetallePedidosModel>();
            DetallePedidoFabrica = new HashSet<DetallePedidosFabricaModel>();
        }
        public int ID_Transfer { get; set; }
        public string Codigo { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        public virtual ICollection<DetallePedidosFabricaModel> DetallePedidoFabrica { get; set; }
    }
}
