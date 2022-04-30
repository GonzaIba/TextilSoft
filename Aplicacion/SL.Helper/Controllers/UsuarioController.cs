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

        public List<Usuario> ObtenerUsuariosCompletos()
        {
            var Familias = ObtenerFamilias();
            var Usuarios = ObtenerUsuarios();
            var UsuariosConPermiso = UsuariosConPermisos(Usuarios.ToList());
            var Usuarioscompletos = UsuariosCompletos(UsuariosConPermiso, Familias.ToList());

            return Usuarioscompletos;
        }

        public IList<Usuario> ObtenerUsuarios() /*=> _mapper.Map<List<Usuario>>(_usuarioService.Get().ToList());*/
        {
            //Aca Llenamos la lista de usuarios con sus permisos
            var UsuariosCompletosDto = _usuarioService.Get().ToList();
            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.AddRange(_mapper.Map<List<Usuario>>(UsuariosCompletosDto));
            return Usuarios;
        }

        private List<Usuario> UsuariosConPermisos(List<Usuario> Usuarios)
        {
            //Aca Llenamos la lista de usuarios con sus permisos
            var UsuariosPermisos = _usuario_PermisoService.Get(includeProperties: "PermisoModel").ToList();
            foreach (var usuario in Usuarios)
            {
                //var UsuariosPermisos = UsuariosCompletosDto.SelectMany(x => x.Usuario_Permisos).Where(x => x.Id_Usuario == usuario.Id).ToList();
                var Permisos = UsuariosPermisos.Where(x => x.Id_Usuario == usuario.Id).ToList();

                usuario?.Permisos?.AddRange(Permisos.Select(x => new Patente
                {
                    Id = x.PermisoModel.Id_Permiso,
                    Nombre = x.PermisoModel.Permiso
                }));

            }
            return Usuarios;
        }

        private List<Usuario> UsuariosCompletos(List<Usuario> Usuarios, List<Familia> Familias)
        {
            var PermisosDto = _usuario_PermisoService.Get().ToList();
            foreach (var usuario in Usuarios)
            {
                foreach (var familia in Familias)
                {
                    var Permisos = PermisosDto.Where(x => x.Id_Permiso == familia.Id && x.Id_Usuario == usuario.Id).FirstOrDefault();
                    if (Permisos != null)
                    {
                        //Si entro a este if es porque es una familia y pertenece a este usuario...
                        Familia family = Familias.Where(x => x.Id == Permisos.Id_Permiso).FirstOrDefault();
                        usuario.Permisos.Add(family);
                    }
                }
            }
            return Usuarios;
        }
        
        public IList<Familia> ObtenerFamilias()
        {
            var PermisosDto = _permisoService.Get().ToList(); //Obtenemos toda la tabla de permisos //Por algún motivo no me traia la bdd actualizada...
            //var PermisosDto = _permisoService.ObtenerPermisos(); //Obtenemos toda la tabla de permisos

            var Permisos = _mapper.Map<List<Patente>>(PermisosDto); //Convertimos los permisos a Patente
            var FamiliasSinCastear = Permisos.Where(x => x.Permiso == TipoPermiso.EsFamilia).ToList(); //
            List<Familia> FamiliasComposite = FamiliasSinCastear.Select(x => new Familia{Id = x.Id,Nombre = x.Nombre,Permiso = x.Permiso}).ToList(); //Convertimos la lista de patentes a lista de familias
            var PadreHijosDto = _permiso_PermisoService.Get().ToList(); //Obtenemos toda la tabla de relacion padre hijo
            //Convertimos las familias a familias composite

            foreach (var FamiliaComposite in FamiliasComposite) //Recorremos las familias para agregar agregar sus hijos...
            {
                var PadreHijos = PadreHijosDto.Where(x => x.Id_Permiso_Padre == FamiliaComposite.Id).ToList(); //Obtenemos las relaciones del padre(familia) con los hijos
                foreach (var item in PadreHijos) //Recorremos los permisos de la familia y se los agregamos
                {
                    var PermisosDeLaFamilia = PermisosDto.Where(x => x.Id_Permiso == item.Id_Permiso_Hijo && x.Permiso != null).ToList(); //Obt
                    foreach (var Permiso in PermisosDeLaFamilia) //Recorremos los permisos de la familia y se lo agregamos
                    {
                        FamiliaComposite.AgregarHijo(new Patente
                        {
                            Id = Permiso.Id_Permiso,
                            Nombre = Permiso.Permiso
                        });
                    }
                }
            }

            //Una vez llegado acá, tenemos una lista de familias con sus permisos, y ahora vamos a agregar familia a otra familia sin que exista dependencia circular
            int Contador = 0;
            foreach (var item in PadreHijosDto)
            {
                var FamiliaHijaDto = PermisosDto.Where(x => x.Id_Permiso == item.Id_Permiso_Hijo && x.Permiso == null).FirstOrDefault(); //A través del id del hijo obtenemos la familia (hija)
                if (FamiliaHijaDto == null)
                    continue;
                foreach (var FamiliaPadre in FamiliasComposite.Where(x => x.Id == item.Id_Permiso_Padre))//A través del id del padre obtenemos la familia (padre)
                {
                    if (PadreHijosDto.Where(x => x.Id_Permiso_Padre == FamiliaPadre.Id).Any() && Contador > 0) //No puede haber dependencia circular entre familias...
                    {
                        Contador = 0;
                        break;
                    }
                    var FamiliaHija = FamiliasComposite.Where(x => x.Id == FamiliaHijaDto.Id_Permiso).FirstOrDefault();
                    FamiliaPadre.AgregarHijo(FamiliaHija);
                    Contador++;
                }
            }

            return FamiliasComposite;
        }



    }
}




















//var FamiliasDto = _permisoService.Get(x => x.Permiso == null).ToList(); //Obtenemos las familias

//List<Familia> FamiliasComposite = _mapper.Map<List<Familia>>(FamiliasDto); //Convertimos las familias a familias composite

//foreach (var FamiliaComposite in FamiliasComposite) //Recorremos las familias y agregamos sus permisos
//{
//    var PadreHijos = _permiso_PermisoService.Get(x => x.Id_Permiso_Padre == FamiliaComposite.Id).ToList();
//    foreach (var item in PadreHijos) //Recorremos los permisos de la familia y se los agregamos
//    {
//        var PermisosDeLaFamilia = _permisoService.Get(x => x.Id_Permiso == item.Id_Permiso_Hijo && x.Permiso != null).ToList();
//        foreach (var Permiso in PermisosDeLaFamilia) //Recorremos
//        {
//            FamiliaComposite.AgregarHijo(new Patente
//            {
//                Id = Permiso.Id_Permiso,
//                Nombre = Permiso.Permiso
//            });
//        }
//    }
//}

//return FamiliasComposite;