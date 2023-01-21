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
    public interface IUsuarioService : IGenericService<UsuarioModel>
    {
        LoginResult AccesResult(UsuarioModel usuarioModel,bool Result);
        LoginResult Login(Login usuarioModel);
        bool Register(UsuarioModel usuarioModel);
        //string Update(UsuarioModel usuarioModel);
        //string Delete(UsuarioModel usuarioModel);
        void GuardarPermisos(Usuario usuarioModel);
        void EnviarConfirmacionDeEmail(string nombre, string email);
        void RecuperarContraseñaEmail(string email);
    }
}
