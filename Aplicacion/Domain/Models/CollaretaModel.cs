using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CollaretaModel : GenericEntity
    {
        public int ID_Collareta { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    }
}
