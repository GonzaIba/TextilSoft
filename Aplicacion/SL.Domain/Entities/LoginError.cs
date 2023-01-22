using SL.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class LoginResult
    {
        public LoginResultEnum LoginResultEnum { get; set; }
        public string Message { get; set; }
    }
}
