using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Enums;
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
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IUsuario_PermisoService usuario_PermisoService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
            _mapper = mapper;
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
            try
            {
                _usuarioService.GuardarPermisos(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public List<Usuario> GetAllUsers()
        {
            var UsuariosCompletosDto = _usuarioService.Get(includeProperties: "Usuario_Permisos,Usuario_Permisos.PermisoModel").ToList();
            var UsuariosCompletos = _mapper.Map<List<Usuario>>(UsuariosCompletosDto);

            var test = _mapper.Map<List<Patente>>(UsuariosCompletosDto.Select(x => x.Usuario_Permisos.Select(y => y.PermisoModel).ToList()).ToList());

            foreach (var item in UsuariosCompletosDto)
            {
                var UsuariosPermisos = item.Usuario_Permisos.ToList(); //Obtenemos la tabla intermedia entre Usuarios y Permisos
                var usuario = UsuariosCompletos.FirstOrDefault(x => x.Id == item.Id_Usuario); //Obtenemos el usuario por el id
                
                //if (UsuariosPermisos.Select(x => x.PermisoModel).Where(x => x.Permiso == null).Any()) //Preguntamos si hay una familia...
                //{
                //    var Familia =UsuariosPermisos.Select(x => x.PermisoModel).Where(x => x.Permiso == null).FirstOrDefault(); //Obtenemos la familia
                //    //usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente { Id = x.PermisoModel.Id_Permiso, Nombre = x.PermisoModel.Permiso, Hijos = Familia.}));
                //}
                //else
                    usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente { Id = x.PermisoModel.Id_Permiso, Nombre = x.PermisoModel.Permiso }));
            }
            return UsuariosCompletos;
        }
    }
}





//Llenar patentes o permisos al usuario ya que todavia no se encontro la manera con automapper.
//foreach (var item in UsuariosCompletosDto.FirstOrDefault().Usuario_Permisos)
//{
//    Componente patente = new Patente();
//    patente.Id = item.PermisoModel.Id_Permiso;
//    patente.Nombre = item.PermisoModel.Permiso;
//    foreach (var item2 in UsuariosCompletos)
//    {
//        if (item2.Id == item.Id_Usuario)
//        {
//            item2.Permisos.Add(patente);
//            break;
//        }
//    }
//}