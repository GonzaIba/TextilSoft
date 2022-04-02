using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PedidosModel : GenericEntity
    {
        public PedidosModel()
        {
            this.DetallePedido = new HashSet<DetallePedidosModel>();
            this.Factura = new HashSet<FacturasModel>();
            this.OrdenDeTrabajo = new HashSet<OrdenDeTrabajoModel>();
        }

        public int ID_Pedido { get; set; }
        public int NumeroPedido { get; set; }
        public string EstadoPedido { get; set; }
        public Nullable<decimal> TotalPago { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Empleados { get; set; }
        public Nullable<decimal> Seña { get; set; }

        public virtual ClientesModel Cliente { get; set; }
        public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        public virtual EmpleadosModel Empleados { get; set; }
        public virtual ICollection<FacturasModel> Factura { get; set; }
        public virtual ICollection<OrdenDeTrabajoModel> OrdenDeTrabajo { get; set; }
    
    }
}
