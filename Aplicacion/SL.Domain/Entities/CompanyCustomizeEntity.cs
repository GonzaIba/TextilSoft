using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class CompanyCustomizeEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Color { get; set; }
    }
}
