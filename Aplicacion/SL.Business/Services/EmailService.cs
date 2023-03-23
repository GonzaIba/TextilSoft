using Microsoft.AspNet.Identity;
using SL.Contracts.Services;
using SL.Domain.Model;
using SL.EmailHelper;
using SL.EmailHelper.Configurations;
using SL.EmailHelper.Factory;
using SL.Helper.Services.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SL.Business.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailSendGridConfiguration _emailSendGridConfiguration;
        private readonly IGenericEmailFactory _genericEmailFactory;

        public EmailService(
            EmailSendGridConfiguration emailSendGridConfiguration,
            IGenericEmailFactory GenericEmailFactory
            )
        {
            _emailSendGridConfiguration = emailSendGridConfiguration;
            _genericEmailFactory = GenericEmailFactory;
        }
        
        public void RegistrationEmail(UsuarioModel user, int CodigoVerificacion)
        {
            try
            {
                var message = new Message
                (
                    to: new string[] { user.Email },
                    subject: "Registro de usuario",
                    content: $"Hola {user.Nombre}. Confirme su cuenta para hacer uso del sistema!",
                    emailFrom: _emailSendGridConfiguration.From,
                    attachments: null
                );
                string body = string.Empty;
                try
                {
                    body = HtmlDocumentService.GetHtmlDocument("Register.html", null, new List<string> { Convert.ToString(CodigoVerificacion) });

                }
                catch
                {
                    body = "Su código de verificación es: " + CodigoVerificacion;
                }
                message.Content += body;
                SendEmail(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void ForgotPasswordSendEmail(UsuarioModel user, string newPassword)
        {

            var message = new Message
                (
                    to: new string[] { user.Email },
                    subject: "Restauración de contraseña",
                    content: "Hola "+user.Nombre+"! Su nueva contraseña es "+ newPassword,
                    emailFrom: _emailSendGridConfiguration.From,
                    attachments: null
                );
            string body = string.Empty;
            try
            {
                body = HtmlDocumentService.GetHtmlDocument("ForgotPassword.html", newPassword);
            }
            catch
            {
                body = "Su código de verificación es: " + newPassword;
            }

            message.Content += body;
            SendEmail(message);
        }

        public void NotificateFatalError(string companyMail, string mensaje)
        {
            var message = new Message
                (
                    to: new string[] { companyMail },
                    subject: "ERROR FATAL EN EL SISTEMA",
                    content: "Ocurrió un error fatal en sus sistema, le adjuntamos los detalles: \n"+mensaje,
                    emailFrom: _emailSendGridConfiguration.From,
                    attachments: null
                );

            //string body = HtmlDocumentService.GetHtmlDocument("ForgotPassword.html", null);
            //message.Content = body;
            SendEmail(message);
        }

        #region Helpers    
        private string SendEmail(Message message, string files = null)
        {
            var EmailService = _genericEmailFactory.GetDefault();
            var result = EmailService.SendEmailAsync(message);
            return result.Data;
        }
        #endregion
    }
}
