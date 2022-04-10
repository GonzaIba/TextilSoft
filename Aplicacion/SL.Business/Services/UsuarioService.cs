using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
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
        public UsuarioService(IUnitOfWork unitOfWork, IConfiguration configuration) 
        : base(unitOfWork, unitOfWork.GetRepository<IUsuarioRepository>())
        {
            _configuration = configuration;
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
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña && x.EmailConfirmado).FirstOrDefault();
            else
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario && x.Contraseña == usuarioLogin.Contraseña).FirstOrDefault();


            if (Usuario is null)
            {
                LoginResult = false;
                Usuario = Get(x => x.Nombre == usuarioLogin.Usuario).FirstOrDefault();
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

        #endregion








        #region Email
        public void SendPasswordChangedMail(string email)
        {
            
        }
        #endregion
    }
}
