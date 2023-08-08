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
            this.DetallePedidosFabrica = new HashSet<DetallePedidosFabricaModel>();
            this.ProductoDefectos = new HashSet<ProductoDefectoModel>();
        }

        public int ID_Producto { get; set; }
        public Guid CodigoProducto { get; set; }
        public string Composicion { get; set; }
        public int ID_TipoPrenda { get; set; }    
        public int ID_TelaBase { get; set; }
        public int ID_TelaCombinacion { get; set; }
        public int ID_BolsilloInterior { get; set; }
        public int ID_CinturaInterior { get; set; }
        public int ID_Collareta { get; set; }
        public int ID_Lazo { get; set; }
        public int ID_Vivo { get; set; }
        public int ID_Forreria { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string TallePrenda { get; set; }
        public string ImagenPrenda { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<DetallePedidosModel> DetallePedido { get; set; }
        public virtual ICollection<DetallePedidosFabricaModel> DetallePedidosFabrica { get; set; }
        public virtual ICollection<VentasModel> Venta { get; set; }
        public virtual ICollection<ProductoDefectoModel> ProductoDefectos { get; set; }

        public virtual TipoPrendaModel TipoPrenda { get; set; }
        public virtual TelaBaseModel TelaBase { get; set; }
        public virtual TelaCombinacionModel TelaCombinacion { get; set; }
        public virtual BolsilloInteriorModel BolsilloInterior { get; set; }
        public virtual CinturaInteriorModel CinturaInterior { get; set; }
        public virtual CollaretaModel Collareta { get; set; }
        public virtual LazoModel Lazo { get; set; }
        public virtual VivoModel Vivo { get; set; }
        public virtual ForreriaModel Forreria { get; set; }
    }
}
