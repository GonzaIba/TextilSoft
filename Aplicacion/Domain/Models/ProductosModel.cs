using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class ProductosModel : GenericEntity
    {
        public ProductosModel()
        {
            this.DetallePedido = new HashSet<DetallePedidosModel>();
            this.Venta = new HashSet<VentasModel>();
        }

        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string Color { get; set; }
        public string Composicion { get; set; }
        public string Estampa { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Tejido { get; set; }
        public string TallePrenda { get; set; }
        public string TipoProducto { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        public virtual ICollection<VentasModel> Venta { get; set; }
    }
}
