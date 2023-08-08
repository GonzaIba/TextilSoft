using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductoDefectoEntity
    {
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public string Motivo { get; set; }
        public string QuienRegistro { get; set; }
        public DateTime FechaRegistrado { get; set; }
    }
}
