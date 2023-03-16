using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ListarPedidosFabricaEntity
    {
        public int PedidoID { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoPedidosFabricaEnum EstadoPedidos;
        public string AtendidoPor { get; set; }
    }
}
