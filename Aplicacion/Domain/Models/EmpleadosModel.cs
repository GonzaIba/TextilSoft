using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class EmpleadosModel : GenericEntity
    {
        public EmpleadosModel()
        {
            this.Pedidos = new HashSet<PedidosModel>();
        }

        public int ID_Empleados { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Residencia { get; set; }
        public string Legajo { get; set; }
        public string DNI { get; set; }
        public virtual ICollection<PedidosModel> Pedidos { get; set; }
    }
}
