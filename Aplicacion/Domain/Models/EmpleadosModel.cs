using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            this.PedidosFabrica = new HashSet<PedidosFabricaModel>();
        }
        [Key]
        public Guid ID_Empleados { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Residencia { get; set; }
        public string Legajo { get; set; }
        public int DNI { get; set; }
        public virtual ICollection<PedidosModel> Pedidos { get; set; }
        public virtual ICollection<PedidosFabricaModel> PedidosFabrica { get; set; }
        //public Usuario usuario { get; set; }
    }
}
