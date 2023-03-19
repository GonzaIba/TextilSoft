using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Model
{
    public class CompanySendGridConfigModel
    {
        public int CompanySendGridConfigId { get; set; }
        public int CompanyId { get; set; }
        public string ApiKey { get; set; }
        public string From { get; set; }
        public string DisplayName { get; set; }
        public string ApiKeyId { get; set; }

        public CompanyModel Company { get; set; }
    }
}
