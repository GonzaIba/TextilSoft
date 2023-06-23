using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TelaCombinacionModel : GenericEntity
    {
        public int ID_TelaCombinacion { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }
}
