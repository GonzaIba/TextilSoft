using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Configurations.Authentication
{
    public class AuthenticationConfig
    {
        public PasswordConfig PasswordConfig { get; set; }
        public bool UserRequireUniqueEmail { get; set; }
        public bool SignInRequireConfirmedAccount { get; set; }
        public int MaxFailedAccessAttempts { get; set; }
    }
}
