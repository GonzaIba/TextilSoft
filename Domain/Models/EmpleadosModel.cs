using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class EmpleadosModel
    {
        public EmpleadosModel()
        {
            this.ProductoProveedor = new HashSet<ProductosProveedorModel>();
            this.Pedidos = new HashSet<PedidosModel>();
        }

        public int ID_Empleados { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Residencia { get; set; }
        public string Legajo { get; set; }
        public Nullable<int> DNI { get; set; }

        public virtual ICollection<ProductosProveedorModel> ProductoProveedor { get; set; }
        public virtual ICollection<PedidosModel> Pedidos { get; set; }
    }
}
