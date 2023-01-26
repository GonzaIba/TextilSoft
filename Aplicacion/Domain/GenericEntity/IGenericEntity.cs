using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities
{
    public interface IGenericEntity
    {
        DateTime CreateDate { get; set; }
        Nullable<DateTime> UpdateDate { get; set; }
        bool Active { get; set; }
    }
}
