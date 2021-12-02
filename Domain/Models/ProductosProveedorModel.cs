using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductosProveedorModel
    {
        public int ID_ProductoProveedor { get; set; }
        public string NombreProducto { get; set; }
        public string TipoTela { get; set; }
        public string CantidadRollos { get; set; }
        public string MarcaTela { get; set; }
        public string Precio { get; set; }
        public int ID_Proveedor { get; set; }
        public int ID_Empleados { get; set; }

        public virtual EmpleadosModel Empleados { get; set; }
        public virtual ProveedoresModel Proveedor { get; set; }
    }
}
