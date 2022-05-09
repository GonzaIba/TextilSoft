using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanyModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCuil { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyLocation { get; set; }
        public bool Active { get; set; }
    }
}
