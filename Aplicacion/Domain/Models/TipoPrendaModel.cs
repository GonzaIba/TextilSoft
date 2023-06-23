using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TipoPrendaModel : GenericEntity
    {
        public int ID_TipoPrenda { get; set; }
        public string TipoPrenda { get; set; }
    }
}
