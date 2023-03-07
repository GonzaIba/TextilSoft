using Microsoft.AspNet.Identity;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Contracts.Services
{
    public interface IEmailService
    {
        void RegistrationEmail(UsuarioModel user, int codigoVerificacion);

        void ForgotPasswordSendEmail(UsuarioModel user, string newPassword);

        void NotificateFatalError(string companyMail, string message);
    }
}
