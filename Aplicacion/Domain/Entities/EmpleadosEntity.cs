using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmpleadosEntity
    {
        public Guid ID_Empleados { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Residencia { get; set; }
        public string Legajo { get; set; }
        public string DNI { get; set; }

        //public virtual ICollection<PedidosEntity> Pedidos { get; set; }
    }
}
