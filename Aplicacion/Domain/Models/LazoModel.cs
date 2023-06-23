using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LazoModel : GenericEntity
    {
        public int ID_Lazo { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }
}
