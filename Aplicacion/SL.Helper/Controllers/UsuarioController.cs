using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Http;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Domain.Model;
using SL.Helper.Configurations;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        private readonly CompanyConfiguration _companyConfiguration;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public UsuarioController(IUsuarioService usuarioService,
            IUsuario_PermisoService usuario_PermisoService,
            IPermisoService permisoService,
            IPermiso_PermisoService permiso_PermisoService,
            IMapper mapper,
            ILogger logger,
            CompanyConfiguration companyConfiguration
            )
        {
            _usuarioService = usuarioService;
            _usuario_PermisoService = usuario_PermisoService;
            _permisoService = permisoService;
            _permiso_PermisoService = permiso_PermisoService;
            _mapper = mapper;
            _logger = logger;
            _companyConfiguration = companyConfiguration;
        }

        public bool Crearusuario(Register register, int CompanyId)
        {
            try
            {
                var usuario = _mapper.Map<UsuarioModel>(register);
                usuario.CompanyId = CompanyId;
                return _usuarioService.Register(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LoginResult LoginUser(Login usuarioLogin)
        {
            try
            {
                var ResultadoLogin = _usuarioService.Login(usuarioLogin);
                //Logger.GenerateInfo($"El usuario {usuarioLogin.Usuario} se logueo correctamente");
                return ResultadoLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Usuario ObtenerUsuarioConPermisos(Login login)
        {
            try
            {
                var UsuarioDto = _usuarioService.Get(x => x.Nombre == login.Usuario && x.Contraseña == login.Contraseña && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                var Usuario = _mapper.Map<Usuario>(UsuarioDto);

                var Familias = ObtenerFamilias();
                var UsuarioConPermisos = ObtenerPermisosDeUsuario(Usuario);
                Usuario = UsuariosCompletos(UsuarioConPermisos, Familias.ToList()).FirstOrDefault();
                _logger.GenerateInfo("Logueo exitoso de: "+Usuario.Nombre);
                _logger.SetUser(Usuario);

                return Usuario;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener el usuario con sus permisos", ex);
                throw ex;
            }

        }

        public Usuario ObtenerUsuarioConPermisos(int DNI)
        {
            try
            {
                _logger.GenerateLogPerformance("Init ObtenerUsuarioConPermisos");
                var UsuarioDto = _usuarioService.Get(x => x.DNI == DNI && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                var Usuario = _mapper.Map<Usuario>(UsuarioDto);

                var Familias = ObtenerFamilias();
                var UsuarioConPermisos = ObtenerPermisosDeUsuario(Usuario);
                Usuario = UsuariosCompletos(UsuarioConPermisos, Familias.ToList()).FirstOrDefault();
                _logger.GenerateLogPerformance("Finish ObtenerUsuarioConPermisos");
                return Usuario;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener el usuario con sus permisos", ex);
                throw ex;
            }
        }

        public Usuario ObtenerUsuario(Login login)
        {
            try
            {
                var UsuarioDto = _usuarioService.Get(x => x.Nombre == login.Usuario && x.Contraseña == login.Contraseña && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                if(UsuarioDto is null)
                    UsuarioDto = _usuarioService.Get(x => x.Nombre == login.Usuario && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                
                var Usuario = _mapper.Map<Usuario>(UsuarioDto);
                return Usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string QuitarPermiso(Usuario usuario, Componente c)
        {
            try
            {
                var Usuario = _usuarioService.Get(x => x.Id_Usuario == usuario.Id && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                if (Usuario != null)
                {
                    var permiso = _permisoService.Get(x => x.Id_Permiso == c.Id && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                    if (permiso != null)
                    {
                        var usuario_Permiso = _usuario_PermisoService.Get(x => x.Id_Usuario == usuario.Id && x.Id_Permiso == permiso.Id_Permiso, tracking: true).FirstOrDefault();
                        if (usuario_Permiso != null)
                        {
                            _usuario_PermisoService.EliminarPermisoDeUsuario(usuario_Permiso);
                            return "Ok";
                        }
                        else
                            return "No se puede quitar un permiso que depende de un nivel superior";
                    }
                    else
                        return "No se encontró el permiso, contacte con el soporte o refresque la ventana";
                }
                else
                    return "No se encontró el usuario, contacte con el soporte o refresque la ventana";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EnviarConfirmacionEmail(string email)
        {
            try
            {
                var user = _usuarioService.Get(x => x.Email == email && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).FirstOrDefault();
                if(user !=null)
                    _usuarioService.EnviarConfirmacionDeEmail(user.Nombre, email);
                else
                    throw new Exception("No se encontró el usuario");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RecuperarContraseña(string nombre, string email)
        {
            try
            {
                _usuarioService.RecuperarContraseñaEmail(nombre, email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool ValidarCodigoDeVerificacion(Usuario usuario, int codigoVerificacion)
        {
            try
            {
                var Usuario = _usuarioService.Get(x => x.Id_Usuario == usuario.Id && x.CompanyId == _companyConfiguration.CompanyId, tracking: true).FirstOrDefault();
                if(Usuario.VerifyCode == codigoVerificacion)
                {
                    Usuario.EmailConfirmado = true;
                    _usuarioService.Actualizar(Usuario);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarConfiguracionUsuario(UsuarioInformacion Usuarioinformacion)
        {
            try
            {
                var usuarioDto = _usuarioService.Get(x => x.Id_Usuario == Usuarioinformacion.Id, tracking: true).FirstOrDefault();
                usuarioDto.Email = Usuarioinformacion.Email;
                usuarioDto.NumeroTeléfono = Usuarioinformacion.Celular;
                usuarioDto.EnableAnimators = Usuarioinformacion.EnableAnimators;
                usuarioDto.EnableSlicePanel = Usuarioinformacion.EnableSlicePanel;
                usuarioDto.EnableVolume = Usuarioinformacion.EnableVolume;
                usuarioDto.Volume = Usuarioinformacion.Volume;
                _usuarioService.Actualizar(usuarioDto);
                _logger.GenerateInfo("Actualización de usuario exitoso");
                return true;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al actualizar el usuario", ex);
                throw ex;
            }
        }

        public UsuarioInformacion ObtenerInformacionUsuario(Usuario usuario)
        {
            try
            {
                var usuarioDto = _usuarioService.Get(x => x.Id_Usuario == usuario.Id, tracking: true).FirstOrDefault();
                UsuarioInformacion userInfo = _mapper.Map<UsuarioInformacion>(usuarioDto);
                return userInfo;
            }
            catch (Exception ex)
            {
                _logger.GenerateFatalLog("Ocurrió un error fatal al obtener el usuario", ex);
                throw ex;
            }
        }
        
        public bool CambiarContraseña(int id,string oldPassword, string newPassword)
        {
            try
            {

                var usuarioDto = _usuarioService.Get(x => x.Id_Usuario == id, tracking: true).FirstOrDefault();
                if (usuarioDto.Contraseña == oldPassword)
                {
                    if (usuarioDto.Contraseña == newPassword)
                        return false;

                    usuarioDto.Contraseña = newPassword;
                    _usuarioService.Actualizar(usuarioDto);
                    _logger.GenerateInfo("Actualización de usuario exitoso");
                    return true;
                }
                else
                {
                    _logger.GenerateInfo("Contraseña incorrecta");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.GenerateLogError("Ocurrió un error al cambiar la contraseña",ex);
                throw;
            }
        }

        #region Composite
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

        public List<Usuario> ObtenerPermisosDeUsuario(Usuario usuario)
        {
            try
            {
                //En vez de crear un método, simplemente reutilizamos el de listas
                List<Usuario> Usuarios = new List<Usuario>();
                Usuarios.Add(usuario);
                return UsuariosConPermisos(Usuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            
        public List<Usuario> ObtenerTodosLosUsuarioConPermisos()
        {
            try
            {
                var Familias = ObtenerFamilias();
                var Usuarios = ObtenerUsuarios();
                var UsuariosConPermiso = UsuariosConPermisos(Usuarios.ToList());
                var Usuarioscompletos = UsuariosCompletos(UsuariosConPermiso, Familias.ToList());

                return Usuarioscompletos;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public IList<Usuario> ObtenerUsuarios(bool IsOwner = false) /*=> _mapper.Map<List<Usuario>>(_usuarioService.Get().ToList());*/
        {
            //Aca Llenamos la lista de usuarios con sus permisos. Solo obtenemos los que no son administrador ya que es inútil agregarle patentes ya que tiene el nivel mas superior.
            dynamic UsuariosCompletosDto;
            if (IsOwner)
                UsuariosCompletosDto = _usuarioService.Get(x =>x.CompanyId == _companyConfiguration.CompanyId).ToList();
            else
                UsuariosCompletosDto = _usuarioService.Get(x => !x.IsOwner && x.CompanyId == _companyConfiguration.CompanyId).ToList();

            List<Usuario> Usuarios = new List<Usuario>();
            Usuarios.AddRange(_mapper.Map<List<Usuario>>(UsuariosCompletosDto));
            return Usuarios;
        }

        private List<Usuario> UsuariosConPermisos(List<Usuario> Usuarios)
        {
            //Aca Llenamos la lista de usuarios con sus permisos
            var UsuariosPermisos = _usuario_PermisoService.Get(includeProperties: "PermisoModel").ToList();

            Usuarios.ForEach(x =>
            {
                var Permisos = UsuariosPermisos.Where(z => z.Id_Usuario == x.Id).ToList();
                x?.Permisos?.AddRange(Permisos.Where(x => x.PermisoModel.Permiso != null).Select(x => new Patente
                {
                    Id = x.PermisoModel.Id_Permiso,
                    Nombre = x.PermisoModel.Nombre,
                    Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), x.PermisoModel.Permiso)
                }));
            });

            ////Vaciamos para ver si el foreach de arriba es igual al de abajo
            ////Usuarios.ForEach(x => x.Permisos.ForEach(y => y.VaciarHijos()));
            //Usuarios.ForEach(x => x.Permisos.Clear());
            //foreach (var usuario in Usuarios)
            //{
            //    //var UsuariosPermisos = UsuariosCompletosDto.SelectMany(x => x.Usuario_Permisos).Where(x => x.Id_Usuario == usuario.Id).ToList();
            //    var Permisos = UsuariosPermisos.Where(x => x.Id_Usuario == usuario.Id).ToList();

            //    usuario?.Permisos?.AddRange(Permisos.Where(x => x.PermisoModel.Permiso != null).Select(x => new Patente
            //    {
            //        Id = x.PermisoModel.Id_Permiso,
            //        Nombre = x.PermisoModel.Nombre,
            //        Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), x.PermisoModel.Permiso)
            //    }));
            //}
            return Usuarios;
        }

        private List<Usuario> UsuariosCompletos(List<Usuario> Usuarios, List<Familia> Familias)
        {
            var PermisosDto = _usuario_PermisoService.Get().ToList();

            Usuarios.ForEach(x =>
            {
                Familias.ForEach(z =>
                {
                    var Permisos = PermisosDto.Where(y => y.Id_Permiso == z.Id && y.Id_Usuario == x.Id).FirstOrDefault();
                    if (Permisos != null)
                    {
                        //Si entro a este if es porque es una familia y pertenece a este usuario...
                        Familia family = Familias.Where(x => x.Id == Permisos.Id_Permiso).FirstOrDefault();
                        //Eliminamos la familia del usuario porque esta incompleta y la reemplazamos por la nueva
                        x.Permisos.RemoveAll(x => x.Id == family.Id);
                        x.Permisos.Add(family);
                    }
                });
            });

            ///////////////////////

            foreach (var usuario in Usuarios)
            {
                foreach (var familia in Familias)
                {
                    var Permisos = PermisosDto.Where(x => x.Id_Permiso == familia.Id && x.Id_Usuario == usuario.Id).FirstOrDefault();
                    if (Permisos != null)
                    {
                        //Si entro a este if es porque es una familia y pertenece a este usuario...
                        Familia family = Familias.Where(x => x.Id == Permisos.Id_Permiso).FirstOrDefault();

                        //Eliminamos la familia del usuario porque esta incompleta y la reemplazamos por la nueva
                        usuario.Permisos.RemoveAll(x => x.Id == family.Id);

                        usuario.Permisos.Add(family);
                    }
                }
            }
            return Usuarios;
        }

        public IList<Familia> ObtenerFamilias()
        {
            var PermisosDto = _permisoService.Get(x => x.CompanyId == _companyConfiguration.CompanyId, tracking: true).ToList(); //Obtenemos toda la tabla de permisos //Por algún motivo no me traia la bdd actualizada...
            //var PermisosDto = _permisoService.ObtenerPermisos(); //Obtenemos toda la tabla de permisos

            var Permisos = _mapper.Map<List<Patente>>(PermisosDto); //Convertimos los permisos a Patente
            var FamiliasSinCastear = Permisos.Where(x => x.Permiso == TipoPermiso.EsFamilia).ToList(); //
            List<Familia> FamiliasComposite = FamiliasSinCastear.Select(x => new Familia{Id = x.Id,Nombre = x.Nombre,Permiso = x.Permiso}).ToList(); //Convertimos la lista de patentes a lista de familias
            var PadreHijosDto = _permiso_PermisoService.Get(tracking:true).ToList(); //Obtenemos toda la tabla de relacion padre hijo
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
                            Nombre = Permiso.Nombre,
                            Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), Permiso.Permiso)
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
                    if (PadreHijosDto.Where(x => x.Id_Permiso_Padre == FamiliaPadre.Id).Any()) //No puede haber dependencia circular entre familias...
                    {
                        Contador = 0;
                        var FamiliaHija2 = FamiliasComposite.Where(x => x.Id == FamiliaHijaDto.Id_Permiso).FirstOrDefault();
                        FamiliaPadre.AgregarHijo(FamiliaHija2);
                        break;
                    }
                    var FamiliaHija = FamiliasComposite.Where(x => x.Id == FamiliaHijaDto.Id_Permiso).FirstOrDefault();
                    FamiliaPadre.AgregarHijo(FamiliaHija);
                    Contador++;
                }
            }

            return FamiliasComposite;
        }

        public bool ExisteUsuario(string posibleUsuario)
        {
            try
            {
                var result = _usuarioService.Get(x => x.Nombre == posibleUsuario && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).Any();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ExisteEmail(string posibleEmail)
        {
            try
            {
                var result = _usuarioService.Get(x => x.Email == posibleEmail && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).Any();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteDNI(int posibleDNI)
        {
            try
            {
                var result = _usuarioService.Get(x => x.DNI == posibleDNI && x.CompanyId == _companyConfiguration.CompanyId, tracking: false).Any();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarUsuario(string usuario, string contraseña)
        {
            try
            {
                var result = _usuarioService.Get(x => x.Nombre == usuario && x.Contraseña == contraseña).FirstOrDefault();
                if(result != null)
                    _usuarioService.Eliminar(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
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