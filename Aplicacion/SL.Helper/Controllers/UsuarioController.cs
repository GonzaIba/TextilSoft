using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using SL.Contracts.Services;
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
        private readonly IUsuario_PermisoService _usuario_PermisoService;

        public UsuarioController(IUsuarioService usuarioService, IUsuario_PermisoService usuario_PermisoService)
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
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
        public List<UsuarioModel> GetAll() => _usuarioService.GetAll().ToList();

        public void GuardarPermisos(Usuario usuario)
        {
            try
            {
                _usuarioService.GuardarPermisos(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
    }
}
