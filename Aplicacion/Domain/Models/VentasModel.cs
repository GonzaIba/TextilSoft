using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class VentasModel : GenericEntity
    {
        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public Guid CreateUser { get; set; }
        public decimal TotalCapitalRecibido { get; set; }

        public virtual ProductosModel Producto { get; set; }
    }
}
