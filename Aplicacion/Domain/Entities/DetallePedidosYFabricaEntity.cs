using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetallePedidosYFabricaEntity
    {
        public string Acciones { get; set; }
        public Guid Codigo { get; set; }
        public string Detalle { get; set; }
        public string Color { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
