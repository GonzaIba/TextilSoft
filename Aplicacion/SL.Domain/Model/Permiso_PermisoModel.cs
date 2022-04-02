using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class Permiso_PermisoModel
    {
        public int Id_Permiso_Permiso { get; set; }
        public int Id_Permiso_Padre { get; set; }
        public int Id_Permiso_Hijo { get; set; }
    }
}
