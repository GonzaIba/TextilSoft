using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class Usuario_PermisoModel
    {
        //public int Id_Usuario_Permiso { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Permiso { get; set; }

        public UsuarioModel UsuarioModel { get; set; }
        public PermisoModel PermisoModel { get; set; }
    }
}
