using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProveedoresModel
    {
        public ProveedoresModel()
        {
            this.ProductoProveedor = new HashSet<ProductosProveedorModel>();
        }
        public int ID_Proveedor { get; set; }
        public int DNI { get; set; }
        public string EstadoProveedor { get; set; }
        public DateTime FechaNac { get; set; }
        public string LugarEmpresa { get; set; }
        public string Mail { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<ProductosProveedorModel> ProductoProveedor { get; set; }

    }
}
