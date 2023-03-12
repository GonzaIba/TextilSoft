using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class OrdenDeTrabajoFabricaModel : GenericEntity
    {
        public int ID_OrdenDeTrabajoFabrica { get; set; }
        public Nullable<DateTime> FechaInicio { get; set; }
        public int ID_PedidoFabrica { get; set; }
        public int ID_Sector { get; set; }
        public string EstadoOrden { get; set; }
        public Nullable<DateTime> FechaCerrado { get; set; }
        public Guid CreateUser { get; set; }

        public virtual PedidosFabricaModel PedidosFabrica { get; set; }
        public virtual SectorModel Sector { get; set; }
    }
}
