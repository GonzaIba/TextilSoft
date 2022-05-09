using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class OrdenDeTrabajoModel : GenericEntity
    {
        public int ID_OrdenDeTrabajo { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Sector { get; set; }
        public string EstadoOrden { get; set; }
        public Nullable<System.DateTime> FechaCerrado { get; set; }
        public Nullable<bool> EsPedido { get; set; }
        public Guid CreateUser { get; set; }

        public virtual PedidosModel Pedidos { get; set; }
        public virtual SectorModel Sector { get; set; }
    }
}
