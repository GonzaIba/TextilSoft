using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanyModel
    {
        public CompanyModel()
        {
            this.Usuarios = new HashSet<UsuarioModel>();
            this.Permisos = new HashSet<PermisoModel>();
            this.Loggers = new HashSet<LoggerModel>();          
        }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCuil { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyApiKey { get; set; }
        public bool Active { get; set; }
        
        public ICollection<UsuarioModel> Usuarios { get; set; }
        public ICollection<PermisoModel> Permisos { get; set; }
        public ICollection<LoggerModel> Loggers { get; set; }
        public CompanyCustomizeModel CompanyCustomize { get; set; }
        public CompanySendGridConfigModel CompanySendGridConfig { get; set; }
        public CompanyAuthenticationModel CompanyAuthentication { get; set; }
    }
}
