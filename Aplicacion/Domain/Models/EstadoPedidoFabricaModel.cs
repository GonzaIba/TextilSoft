using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EstadoPedidoFabricaModel : GenericEntity
    {
        public int ID_EstadoPedidoFabrica { get; set; }
        public string Estado { get; set; }
        public ICollection<PedidosFabricaModel> PedidosFabrica { get; set; }
    }
}
