using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProveedoresEntity
    {
        public int DNI { get; set; }

        public DateTime FechaNac { get; set; }

        public string LugarEmpresa { get; set; }

        public string Mail { get; set; }

        public string Nombre { get; set; }
    }
}
