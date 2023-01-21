using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Enums
{
    public enum LoginResultEnum
    {
        Ok,
        UsuarioContraseñaIncorrecto,
        UsuarioBloqueado,
        UsuarioNoExiste,
        MailSinConfirmar,
        MaximoIntentosAlcanzados,
        ErrorDeAplicacion
    }
}
