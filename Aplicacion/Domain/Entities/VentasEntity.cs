using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VentasEntity
    {
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
