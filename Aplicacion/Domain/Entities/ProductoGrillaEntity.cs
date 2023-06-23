using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductoGrillaEntity
    {
        public string Acciones { get; set; }
        public int ID_Producto { get; set; }
        public Guid Codigo { get; set; }
        public string NombreProducto { get; set; }
        public Color Color { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
