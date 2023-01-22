using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class AuthenticationConfig
    {
        public AuthenticationConfig()
        {
            PasswordConfig = new PasswordConfig();
        }
        public PasswordConfig PasswordConfig { get; set; }
        public bool UserRequireUniqueEmail { get; set; }
        public bool SignInRequireConfirmedAccount { get; set; }
        public int MaxFailedAccessAttempts { get; set; }
    }
}
