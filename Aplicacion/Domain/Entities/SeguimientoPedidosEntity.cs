using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SeguimientoPedidosEntity
    {
        public int NumeroPedido { get; set; }
        public EstadoPedidosEnum EstadoActual { get; set; }
        public List<HistorialPedidosEntity> HistorialPedidos { get; set; }
    }
}
