using Domain.Enum;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ListarPedidosEntity
    {
        public int ID_Pedido { get; set; }
        public int NumeroPedido { get; set; }
        public decimal TotalPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Seña { get; set; }
        public string Cliente { get; set; }
        //public Guid ID_Empleados { get; set; }
        public EstadoPedidosEnum EstadoPedido { get; set; }
        public string AtendidoPor { get; set; }

        //public virtual ClientesModel Cliente { get; set; }
        //public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        //public virtual EmpleadosModel Empleados { get; set; }
        //public virtual ICollection<FacturasModel> Factura { get; set; }
        //public virtual ICollection<OrdenDeTrabajoModel> OrdenDeTrabajo { get; set; }
        //public virtual EstadoPedidoModel EstadoPedido { get; set; }
    }
}
