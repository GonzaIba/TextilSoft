using Microsoft.AspNet.Identity.EntityFramework;
using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts
{
    public interface IUsuarioController
    {
        void CreateUser(UsuarioModel appIdentityUser);
        string LoginUser(Login appIdentityUser);
        //void UpdateUser(UsuarioModel appIdentityUser);
        //void DeleteUser(UsuarioModel appIdentityUser);
        List<Usuario> ObtenerUsuariosCompletos();
        IList<Usuario> ObtenerUsuarios();
        IList<Familia> ObtenerFamilias();
        void GuardarPermisos(Usuario usuario);
        Usuario GetUser(Login login);
    }
}
