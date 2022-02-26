using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductosProveedorEntity
    {
        public int ID_ProductoProveedor { get; set; }
        public string CodigoProducto { get; set; }
        public string DNI { get; set; }
        public string NombreProducto { get; set; }
        public string TipoTela { get; set; }
        public string CantidadRollos { get; set; }
        public string MarcaTela { get; set; }
        public string Precio { get; set; }
        public int ID_Proveedor { get; set; }

        public virtual ProveedoresEntity Proveedor { get; set; }
    }
}
