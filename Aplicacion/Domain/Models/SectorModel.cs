using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public partial class SectorModel : GenericEntity
    {
        public SectorModel()
        {
            this.OrdenDeTrabajo = new HashSet<OrdenDeTrabajoModel>();
        }

        public int ID_Sector { get; set; }
        public string NombreSector { get; set; }

        public virtual ICollection<OrdenDeTrabajoModel> OrdenDeTrabajo { get; set; }
    }
}
