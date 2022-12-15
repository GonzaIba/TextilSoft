using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business
{
    public class UsuarioService : GenericService<UsuarioModel>, IUsuarioService
    {
        private readonly IConfiguration _configuration;
        private readonly IUsuario_PermisoService _usuario_PermisoService;
        public UsuarioService(IUnitOfWork unitOfWork, IConfiguration configuration, IUsuario_PermisoService usuario_PermisoService) 
        : base(unitOfWork, unitOfWork.GetRepository<IUsuarioRepository>())
        {
            _configuration = configuration;
            _usuario_PermisoService = usuario_PermisoService;
        }

        
        #region Login
        public string AccesResult(UsuarioModel usuarioModel, bool Result)
        {
            string AccesResult = string.Empty;
            int MaxAccesFailedAcept = Convert.ToInt32(_configuration["AuthenticationConfig:MaxFailedAccessAttempts"]);           
            
            if (usuarioModel.AccesFailed == MaxAccesFailedAcept)
            {
                string Email = usuarioModel.Email;
                usuarioModel.Contraseña = "12345";
                usuarioModel.AccesFailed = 0;
                SendPasswordChangedMail(Email);
                _repository.Update(usuarioModel);
                _unitOfWork.Save();
                return AccesResult = "Ya se ha alcanzado el número máximo de intentos de acceso \n" +
                   "Le enviamos un mail con su nueva contraseña";
            }
            else if (Result)
            {
                AccesResult = "Ok";
                usuarioModel.AccesFailed = 0;
            }
            else
            {
                AccesResult = "Usuario o Contraseña incorrecto/s";
                usuarioModel.AccesFailed++;
            }
            
            _repository.Update(usuarioModel);
            _unitOfWork.Save();
            return AccesResult;
        }

        public string Login(Login usuarioLogin)
        {
            bool LoginResult;
            string LoginMessage;
            bool MailRequerido = Convert.ToBoolean(_configuration["AuthenticationConfig:SignInRequireConfirmedAccount"]);
            UsuarioModel Usuario;
            
            if (MailRequerido)
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña && x.EmailConfirmado, tracking: true).FirstOrDefault();
            else
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña, tracking: true).FirstOrDefault();


            if (Usuario is null)
            {
                LoginResult = false;
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario, tracking: true).FirstOrDefault();
                if (Usuario is null)
                    return LoginMessage = "Usuario o Contraseña incorrecto/s";

                LoginMessage = AccesResult(Usuario, LoginResult);
            }
            else
            {
                LoginResult = true;
                LoginMessage = AccesResult(Usuario, LoginResult);
            }
            return LoginMessage;
        }

        public bool Register(UsuarioModel usuarioModel)
        {
            try
            {
                _repository.Insert(usuarioModel);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Composite
        public void GuardarPermisos(Usuario usuario)
        {
            try
            {
                var Users = _usuario_PermisoService.Get(x => x.Id_Usuario == usuario.Id).ToList();
                foreach (var Usuario in Users)
                {
                    _usuario_PermisoService.Eliminar(Usuario);
                }
                foreach (var Permiso in usuario.Permisos)
                {
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.Usuario_Permisos.Add
                    (
                        new Usuario_PermisoModel()
                        {
                            Id_Usuario = usuario.Id,
                            Id_Permiso = Permiso.Id
                        }
                    );
                    Insertar(usuarioModel);
                }
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }
        
        #endregion

        #region Email
        public void SendPasswordChangedMail(string email)
        {
            
        }
        #endregion
    }
}
