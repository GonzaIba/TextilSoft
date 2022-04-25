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
        private readonly IPermisoService _permisoService;
        private readonly IPermiso_PermisoService _permiso_PermisoService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IUsuario_PermisoService usuario_PermisoService, IPermisoService permisoService, IPermiso_PermisoService permiso_PermisoService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
            _permisoService = permisoService;
            _permiso_PermisoService = permiso_PermisoService;
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
            //var UsuariosCompletosDto = _usuarioService.Get(includeProperties: "Usuario_Permisos,Usuario_Permisos.PermisoModel").ToList();
            //var Permisos = _permisoService.Get().ToList();
            //var Permisos_Usuarios = _usuario_PermisoService.Get().ToList();
            //var UsuariosCompletos = _mapper.Map<List<Usuario>>(UsuariosCompletosDto);
            //var result = UsuariosCompletosDto.SelectMany(x => x.Usuario_Permisos.Select(x => x.PermisoModel)).ToList();

            //var test = _mapper.Map<List<Patente>>(Permisos);

            //foreach (var item in UsuariosCompletosDto)
            //{
            //    var UsuariosPermisos = item.Usuario_Permisos.ToList(); //Obtenemos la tabla intermedia entre Usuarios y Permisos
            //    var usuario = UsuariosCompletos.FirstOrDefault(x => x.Id == item.Id_Usuario); //Obtenemos el usuario por el id

            //    //if (UsuariosPermisos.Select(x => x.PermisoModel).Where(x => x.Permiso == null).Any()) //Preguntamos si hay una familia...
            //    //{
            //    //    var Familia = UsuariosPermisos.Select(x => x.PermisoModel).Where(x => x.Permiso == null).FirstOrDefault(); //Obtenemos la familia
            //    //    //usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente { Id = x.PermisoModel.Id_Permiso, Nombre = x.PermisoModel.Permiso, Hijos = Familia.}));
            //    //}
            //    //else
            //    usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente { Id = x.PermisoModel.Id_Permiso, Nombre = x.PermisoModel.Permiso }));
            //}
            //return UsuariosCompletos;




            var UsuariosCompletosDto = _usuarioService.Get(includeProperties: "Usuario_Permisos,Usuario_Permisos.PermisoModel").ToList();
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.AddRange(_mapper.Map<List<Usuario>>(UsuariosCompletosDto));
            foreach (var usuario in Usuarios)
            {
                var UsuariosPermisos = UsuariosCompletosDto.SelectMany(x => x.Usuario_Permisos).Where(x => x.Id_Usuario == usuario.Id).ToList();

                usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente
                {
                    Id = x.PermisoModel.Id_Permiso,
                    Nombre = x.PermisoModel.Permiso
                }));

            }

            return null;
        }

        private List<Usuario> ObtenerUsuarios()
        {
            //Aca Llenamos la lista de usuarios con sus permisos
            var UsuariosCompletosDto = _usuarioService.Get(includeProperties: "Usuario_Permisos,Usuario_Permisos.PermisoModel").ToList();
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.AddRange(_mapper.Map<List<Usuario>>(UsuariosCompletosDto));
            return Usuarios;
        }

        private List<Usuario> UsuariosConPermisos(List<Usuario> Usuarios)
        {
            //Aca Llenamos la lista de usuarios con sus permisos
            foreach (var usuario in Usuarios)
            {
                var UsuariosPermisos = UsuariosCompletosDto.SelectMany(x => x.Usuario_Permisos).Where(x => x.Id_Usuario == usuario.Id).ToList();

                usuario?.Permisos?.AddRange(UsuariosPermisos.Select(x => new Patente
                {
                    Id = x.PermisoModel.Id_Permiso,
                    Nombre = x.PermisoModel.Permiso
                }));

            }
            return Usuarios;
        }
        
        private List<Usuario> UsuariosConFamilia(List<Usuario> usuarios)
        {

            return null;
        }


    }
}