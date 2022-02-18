using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductoEntity
    {
        public string Codigo { get; set; }
        public string Color { get; set; }
        public string Composicion { get; set; }
        public string Estampa { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Tejido { get; set; }
        public string TallePrenda { get; set; }
        public string TipoProducto { get; set; }

    }
}
