using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Configurations.Authentication
{
    public class PasswordConfig
    {
        public int CountLength { get; set; }
        public bool RequireNonAlphanumeric { get; set; }
        public bool RequireLowercase { get; set; }
        public bool RequireUppercase { get; set; }
        public bool RequireDigit { get; set; }

        //public Tester Tester { get; set; }
    }

    public class Tester
    {
        public int test { get; set; }
    }
}
