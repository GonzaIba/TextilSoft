using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            this.HistorialPedidos = new HashSet<HistorialPedidosModel>();
        }

        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public Guid ID_Empleados { get; set; }
        public int ID_EstadoPedido { get; set; }
        public int NumeroPedido { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime Fecha { get; set; }
        public Nullable<decimal> Seña { get; set; }
        public Guid CreateUser { get; set; }

        public virtual ClientesModel Clientes { get; set; }
        public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        public virtual EmpleadosModel Empleados { get; set; }
        public virtual ICollection<FacturasModel> Factura { get; set; }
        public virtual ICollection<OrdenDeTrabajoModel> OrdenDeTrabajo { get; set; }
        public virtual EstadoPedidoModel EstadoPedido { get; set; }
        public virtual ICollection<HistorialPedidosModel> HistorialPedidos { get; set; }

        //Aca hubo un tema al generar la migration. (HELP: ForeingKeys.txt)
    }
}
