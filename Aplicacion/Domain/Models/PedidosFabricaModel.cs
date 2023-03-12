using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class PedidosFabricaModel : GenericEntity
    {
        public PedidosFabricaModel()
        {
            this.DetallePedidosFabrica = new HashSet<DetallePedidosFabricaModel>();
            this.OrdenDeTrabajoFabrica = new HashSet<OrdenDeTrabajoFabricaModel>();
        }

        public int ID_PedidosFabrica { get; set; }
        public Guid ID_Empleados { get; set; }
        public string Detalle { get; set; }
        public Guid CreateUser { get; set; }

        public virtual ICollection<DetallePedidosFabricaModel> DetallePedidosFabrica { get; set; }
        public virtual EmpleadosModel Empleados { get; set; }
        public virtual ICollection<OrdenDeTrabajoFabricaModel> OrdenDeTrabajoFabrica { get; set; }
    }
}
