using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Controllers
{
    public class UsuarioController : IUsuarioController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void CreateUser(UsuarioModel usuarioModel)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public string LoginUser(Login usuarioLogin)
        {
            try
            {
                //var Usuario = _usuarioService.Get(x => x.Nombre == usuarioModel.Nombre,includeProperties: "Usuario_Permisos,Usuario_Permisos.PermisoModel").FirstOrDefault();
                //if (Usuario is null)
                //    return false;
                //else
                //    return true;
                string ResultadoLogin = _usuarioService.Login(usuarioLogin);
                return ResultadoLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GuardarPermisos(Usuario usuario)
        {
            throw new NotImplementedException();
        }

    }
}
