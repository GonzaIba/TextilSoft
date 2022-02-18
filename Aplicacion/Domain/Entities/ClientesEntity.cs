using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ClientesEntity
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public DateTime FechaNac { get; set; }

        public string Residencia { get; set; }

        public string Mail { get; set; }

        public string Telefono { get; set; }
    }
}
