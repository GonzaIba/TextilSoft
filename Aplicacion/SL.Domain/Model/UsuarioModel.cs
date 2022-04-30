using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class UsuarioModel
    {
        //public UsuarioModel()
        //{
        //    Usuario_Permisos = new List<Usuario_PermisoModel>();
        //}
            
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public int DNI { get; set; }
        public int AccesFailed { get; set; }
        public bool EmailConfirmado { get; set; }
        public DateTime? DateTimeEmail { get; set; }
        public string NumeroTeléfono { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
