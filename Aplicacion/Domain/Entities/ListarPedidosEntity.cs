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
        public Nullable<decimal> TotalPago { get; set; }
        public Nullable<DateTime> Fecha { get; set; }
        public Nullable<decimal> Seña { get; set; }
        public string Cliente { get; set; }
        //public Guid ID_Empleados { get; set; }
        public EstadoPedidosEnum EstadoPedido { get; set; }
        public string AtendidoPor { get; set; }
    }
}
