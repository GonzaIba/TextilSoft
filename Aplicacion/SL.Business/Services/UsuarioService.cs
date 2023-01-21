using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Contracts.Services;
using SL.Domain.Entities;
using SL.Domain.Model;
using SL.Helper.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SL.Business
{
    public class UsuarioService : GenericService<UsuarioModel>, IUsuarioService
    {
        private readonly ICompanyService _companyService;
        private readonly IUsuario_PermisoService _usuario_PermisoService;
        private readonly IEmailService _emailService;
        private readonly CompanyConfiguration _companyConfiguration;
        private readonly AuthenticationConfig _authenticationConfig;
        private readonly IMapper _mapper;
        public UsuarioService(IUnitOfWork unitOfWork,
            ICompanyService companyService,
            IUsuario_PermisoService usuario_PermisoService,
            IEmailService emailService,
            CompanyConfiguration companyConfiguration,
            IMapper mapper) 
        : base(unitOfWork, unitOfWork.GetRepository<IUsuarioRepository>())
        {
            _companyService = companyService;
            _usuario_PermisoService = usuario_PermisoService;
            _emailService = emailService;
            _companyConfiguration = companyConfiguration;
            _mapper = mapper;
            _authenticationConfig = _mapper.Map<AuthenticationConfig>(_companyService.ObtenerConfigAutenticacion(_companyConfiguration.CompanyId));
        }

        
        #region Login
        public LoginResult AccesResult(UsuarioModel usuarioModel, bool Result)
        {
            LoginResult loginResult = new LoginResult();
            try
            {
                string AccesResult = string.Empty;
                int MaxAccesFailedAcept = _authenticationConfig.MaxFailedAccessAttempts;

                if (usuarioModel.AccesFailed == MaxAccesFailedAcept)
                {
                    string Email = usuarioModel.Email;
                    usuarioModel.Contraseña = GeneratePassword();
                    usuarioModel.AccesFailed = 0;
                    SendPasswordChangedMail(Email);
                    _repository.Update(usuarioModel);
                    _unitOfWork.SaveChanges();
                    loginResult.Message = "Ya se ha alcanzado el número máximo de intentos de acceso \n" +
                       "Le enviamos un mail con su nueva contraseña";
                    loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.MaximoIntentosAlcanzados;
                }
                else if (Result)
                {
                    loginResult.Message = "Ok";
                    loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.Ok;
                    usuarioModel.AccesFailed = 0;
                }
                else
                {
                    loginResult.Message = "Usuario y/o contraseña incorrectos";
                    loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.UsuarioContraseñaIncorrecto;
                    usuarioModel.AccesFailed++;
                }

                _repository.Update(usuarioModel);
                _unitOfWork.SaveChanges();
                return loginResult;
            }
            catch (Exception ex)
            {
                loginResult.Message = "Ocurrió un error, contacte con el soporte";
                loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.ErrorDeAplicacion;
                return loginResult;
            }
        }

        public LoginResult Login(Login usuarioLogin)
        {
            LoginResult loginResult = new LoginResult();
            try
            {
                bool LoginResult;
                string LoginMessage;
                bool MailRequerido = _authenticationConfig.SignInRequireConfirmedAccount;
                UsuarioModel Usuario;

                if (MailRequerido)
                    Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña && x.EmailConfirmado && x.CompanyId == _companyConfiguration.CompanyId, tracking: true).FirstOrDefault();
                else
                    Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña && x.CompanyId == _companyConfiguration.CompanyId, tracking: true).FirstOrDefault();


                if (Usuario is null)
                {
                    LoginResult = false;
                    Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.CompanyId == _companyConfiguration.CompanyId, tracking: true).FirstOrDefault();
                    if (Usuario is null)
                    {
                        loginResult.Message = "El usuario no existe o esta bloqueado";
                        loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.UsuarioNoExiste;
                        return loginResult;
                    }
                    if (MailRequerido && !Usuario.EmailConfirmado)
                    {
                        loginResult.Message = "Su usuario no tiene el mail confirmado, por favor ingrese el código de verificación recibido en su mail";
                        loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.MailSinConfirmar;
                    }
                    else
                        loginResult = AccesResult(Usuario, LoginResult);
                }
                else
                {
                    LoginResult = true;
                    loginResult = AccesResult(Usuario, LoginResult);
                    if (MailRequerido && loginResult.LoginResultEnum == Domain.Enums.LoginResultEnum.Ok && !Usuario.EmailConfirmado)
                    {
                        loginResult.Message = "Su usuario no tiene el mail confirmado, por favor confirmelo o vuelva a pedir mail de confirmación";
                        loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.MailSinConfirmar;
                    }
                }
                return loginResult;
            }
            catch (Exception ex)
            {
                loginResult.Message = "Ocurrió un error, contacte con el soporte";
                loginResult.LoginResultEnum = Domain.Enums.LoginResultEnum.ErrorDeAplicacion;
                return loginResult;
            }
        }

        public bool Register(UsuarioModel usuarioModel)
        {
            try
            {
                _repository.Insert(usuarioModel);
                _unitOfWork.SaveChanges();
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
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }    
        }
        
        #endregion

        #region ConfirmEmail - Password
        private string GeneratePassword()
        {
            string Password = string.Empty;
            string Caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                Password += Caracteres[random.Next(Caracteres.Length)];
            }
            return Password;
        }
        public void SendPasswordChangedMail(string email)
        {

        }

        public void EnviarConfirmacionDeEmail(string nombre, string email)
        {
            try
            {
                var userModel = _repository.Get(x => x.Nombre == nombre && x.Email == email,tracking:true).FirstOrDefault();
                if (userModel is null)
                    throw new Exception("No existe el usuario");

                int codigo = Generate6Numbers();
                userModel.VerifyCode = codigo;
                _repository.Update(userModel);
                _unitOfWork.SaveChanges();
                _emailService.RegistrationEmail(userModel,codigo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RecuperarContraseñaEmail(string email)
        {
            try
            {
                var userModel = _repository.Get(x => x.Email == email).FirstOrDefault();
                if (userModel is null)
                    throw new Exception("No existe este email");

                userModel.Contraseña = GeneratePassword();
                _repository.Update(userModel);
                _unitOfWork.SaveChanges();

                _emailService.ForgotPasswordSendEmail(userModel,userModel.Contraseña);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        
        private int Generate6Numbers()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

    }
}
