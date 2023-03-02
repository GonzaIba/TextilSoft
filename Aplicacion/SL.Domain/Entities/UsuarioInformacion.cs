using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class UsuarioInformacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int DNI { get; set; }
        public string Celular { get; set; }
        public bool EnableAnimators { get; set; }
        public bool EnableSlicePanel { get; set; }
        public bool EnableVolume { get; set; }
        public int Volume { get; set; }
    }
}
