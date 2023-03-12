using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            Usuario_Permisos = new List<Usuario_PermisoModel>();
        }

        public int Id_Usuario { get; set; }
        public int CompanyId { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string? Email { get; set; }
        public int DNI { get; set; }
        public int AccesFailed { get; set; }
        public bool EmailConfirmado { get; set; }
        public DateTime? DateTimeEmail { get; set; }
        public string NumeroTeléfono { get; set; }
        public bool IsOwner { get; set; }
        public bool Active { get; set; }
        public DateTime? DateDisabledUser { get; set; }
        public Nullable<int> VerifyCode { get; set; }
        public bool EnableAnimators { get; set; }
        public bool EnableSlicePanel { get; set; }
        public bool EnableVolume { get; set; }
        public int Volume { get; set; }
        public string IdiomaSeleccionado { get; set; }

        public CompanyModel Company { get; set; }
        public ICollection<Usuario_PermisoModel> Usuario_Permisos { get; set; }
    }
}
