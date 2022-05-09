using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EstadoPedidoModel : GenericEntity
    {
        public int ID_EstadoPedido { get; set; }
        public string Estado { get; set; }
        public ICollection<PedidosModel> Pedidos { get; set; }
    }
}
