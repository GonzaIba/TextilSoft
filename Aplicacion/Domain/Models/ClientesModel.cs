using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ClientesModel : GenericEntity
    {
        public int ID_Cliente { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EstadoCliente { get; set; }
        public DateTime? FechaNac { get; set; }
        public string Mail { get; set; }
        public int? Telefono { get; set; }
        public string Residencia { get; set; }
        public virtual ICollection<PedidosModel> Pedidos { get; set; }
    }
}
