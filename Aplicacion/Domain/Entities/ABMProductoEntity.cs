using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ABMProductoEntity
    {
        public int ID_Producto { get; set; }
        public string Descripcion { get; set; }
        public Guid CodigoProducto { get; set; }
        public string Composicion { get; set; }
        public string CodigoTipoPrenda { get; set; }
        public string CodigoTelaBase { get; set; }
        public string CodigoTelaCombinacion { get; set; }
        public string CodigoBolsilloInterior { get; set; }
        public string CodigoCinturaInterior { get; set; }
        public string CodigoCollareta { get; set; }
        public string CodigoLazo { get; set; }
        public string CodigoVivo { get; set; }
        public string CodigoForreria { get; set; }
        public decimal Precio { get; set; }
        public string TallePrenda { get; set; }
        public string ImagenPrenda { get; set; }
        public int Stock { get; set; }
    }
}
