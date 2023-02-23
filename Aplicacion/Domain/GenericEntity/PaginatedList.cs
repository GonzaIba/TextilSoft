using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.GenericEntity
{
    public class PaginatedList<T>
    {
        public PaginatedList()
        {
            List = new List<T>();
        }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<T> List { get; set; }
    }
}
